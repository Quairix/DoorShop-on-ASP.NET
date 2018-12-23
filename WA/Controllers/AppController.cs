using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WA.Data;
using WA.Services;
using WA.ViewModels;
using WA.Data.Entities;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Security;
using System.Security.Permissions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Localization;
using System;

namespace WA.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IWARepository _repository;
        private readonly WAContext _context;
        private readonly IHostingEnvironment _app;

        public AppController(IMailService mailService, IWARepository repository, WAContext context, IHostingEnvironment app)
        {
            _mailService = mailService;
             _repository = repository;
            _context = context;
            _app = app;
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
            if(ModelState.IsValid)
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
            string category = Request.Query["category"];
            if (category == null)
            {
                string name = Request.Query["name"];
                if (name == null)
                {
                    var results = _repository.GetAllProducts();
                    return View(results);
                }
                else
                {
                    var results = _repository.GetProductsByName(name);
                    return View(results);
                }
            }
            else
            {
                var results = _repository.GetProductsByCategory(category);
                return View(results);
            }
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
                    ViewBag.UserMessage = "The product has been added.";
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
                    using (FileStream stream = new FileStream(filePath + "\\" + fileNameCut , FileMode.CreateNew, FileAccess.Write, FileShare.ReadWrite))
                    {
                        await upload.CopyToAsync(stream);
                    }
                    model.DoorId = fileNameCut;
                    _context.Products.Add(model);
                    _context.SaveChanges();
                    ViewBag.UserMessage = "The product has been added.";
                }
                    //ViewBag.UserMessage = "A file with this name already exists";
                ModelState.Clear();
            }
            return View();
        }
        [Authorize]
        [HttpGet("Product")]
        public  IActionResult Product(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product =  _repository.GetProductsById((int)id);
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
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            //ScriptManager.RegisterClientScriptBlock(this.GetType(), "{some text for type}", "alert('{Text come to here}'); ", true);
            return RedirectToAction("Shop", "App");
        }

    }
}