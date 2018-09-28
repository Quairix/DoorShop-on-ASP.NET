using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WA.Data;
using WA.Services;
using WA.ViewModels;

namespace WA.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        //private readonly WAContext _context;
        private readonly IWARepository _repository;
        public AppController(IMailService mailService, IWARepository repository/*, WAContext context*/)
        {
            _mailService = mailService;
             _repository = repository;
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
        [Authorize]
        [HttpGet("Shop")]
        public IActionResult Shop()
        {
            var results = _repository.GetAllProducts();
            return View(results);
        }
    }
}