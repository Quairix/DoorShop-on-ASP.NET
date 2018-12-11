using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WA.Data;
using WA.Services;
using WA.ViewModels;
using WA.Data.Entities;

namespace WA.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IWARepository _repository;
        private readonly WAContext _context;

        public AppController(IMailService mailService, IWARepository repository, WAContext context)
        {
            _mailService = mailService;
             _repository = repository;
            _context = context;
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
        [HttpGet("Shop/All")]
        public IActionResult Shop()
        {
                var results = _repository.GetAllProducts();
                return View(results);
        }
        [HttpPost]
        public IActionResult Shop(string name, string category)
        {

            if (name != null)
            {
                var results = _repository.GetProductsByName(name);
                return View(results);
            }
            else
            {
                var results = _repository.GetAllProducts();
                return View(results);
            }
        }
        [HttpGet("Shop/{category}")]
        public IActionResult Shop(string category)
        {
            if (category != null)
            {
                var results = _repository.GetProductsByCategory(category);
                return View(results);
            }
            else
            {
                var results = _repository.GetAllProducts();
                return View(results);
            }
            
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("Cabinet")]
        public IActionResult Cabinet()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Cabinet")]
        public IActionResult Cabinet(Product model)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(model);
                _context.SaveChanges();
                ViewBag.UserMessage = "The product has been added.";
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
            return RedirectToPage("..//Shop//All");
        }

    }
}