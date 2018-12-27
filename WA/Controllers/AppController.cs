using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Threading.Tasks;
using WA.Data;
using WA.Data.Entities;
using WA.Services;
using WA.ViewModels;

namespace WA.Controllers
{
    public class AppController : Controller
    {
        private List<int> listId = new List<int>();
        private readonly IMailService _mailService;
        private readonly IWARepository _repository;
        private readonly WAContext _context;
        private readonly IHostingEnvironment _app;
        private readonly UserManager<StoreUser> _userManager;
        private readonly IMapper _mapper;

        public AppController(IMailService mailService, IWARepository repository,
            IMapper mapper, WAContext context, IHostingEnvironment app,
            UserManager<StoreUser> userManager)
        {
            _mailService = mailService;
            _repository = repository;
            _context = context;
            _mapper = mapper;
            _app = app;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("Contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send the message
                _mailService.SendMessage("example@mail.ru", $"From: {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            return View();
        }
        [HttpGet("About")]
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpGet("Shop")]
        public IActionResult Shop()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("Cabinet")]
        public IActionResult Cabinet()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Cabinet")]
        public async Task<IActionResult> Cabinet(Product model, IFormFile upload)
        {
            if ((ModelState.IsValid) && (upload != null))
            {
                var filePath = _app.WebRootPath + "\\img\\";
                DirectoryInfo dirInfo = new DirectoryInfo(filePath);

                var permissionSet = new PermissionSet(PermissionState.None);
                var writePermission = new FileIOPermission(FileIOPermissionAccess.Write, filePath);

                permissionSet.AddPermission(writePermission);
                FileInfo sameFile = new FileInfo(filePath + upload.FileName);
                if (!sameFile.Exists)
                {
                    using (FileStream stream = new FileStream(filePath + "\\" + upload.FileName, FileMode.CreateNew, FileAccess.Write, FileShare.ReadWrite))
                    {
                        await upload.CopyToAsync(stream);
                    }
                    model.DoorId = upload.FileName;
                    _context.Products.Add(model);
                    _context.SaveChanges();
                    ViewBag.UserMessage = "Товар добавлен.";
                }
                else
                {
                    int number = 1;
                    bool noOut = true;
                    var fileNameCut = upload.FileName.Remove(upload.FileName.IndexOf('.'), upload.FileName.Length - upload.FileName.IndexOf('.'));
                    do
                    {
                        FileInfo newFile1 = new FileInfo(filePath + fileNameCut + number.ToString() + ".jpg");
                        number++;
                        noOut = newFile1.Exists;
                    } while (noOut);
                    fileNameCut += number.ToString() + ".jpg";
                    using (FileStream stream = new FileStream(filePath + "\\" + fileNameCut, FileMode.CreateNew, FileAccess.Write, FileShare.ReadWrite))
                    {
                        await upload.CopyToAsync(stream);
                    }
                    model.DoorId = fileNameCut;
                    _context.Products.Add(model);
                    _context.SaveChanges();
                    ViewBag.UserMessage = "Товар добавлен.";
                }
                //ViewBag.UserMessage = "A file with this name already exists";
                ModelState.Clear();
            }
            return View();
        }
        [Authorize]
        [HttpGet("Product")]
        public IActionResult Product(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _repository.GetProductsById((int)id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Product")]
        public IActionResult Product(int id)
        {
            var product = _repository.GetProductsById((int)id);
            if (product != null)
            {
                //var x = _context.OrderItems.Where(p => p.Product == product).FirstOrDefault();
                //while (x != default)
                //{
                //    _context.OrderItems.Remove(x);
                //    _context.SaveChanges();
                //    x = _context.OrderItems.Where(p => p.ProductId == product.Id).FirstOrDefault();
                //}
                ViewBag.RowsAffected = _context.Database.ExecuteSqlCommand("Delete FROM OrderItem WHERE ProductId = {0}", id);
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return RedirectToAction("Shop", "App");
        }
    }
}