using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WA.Data.Entities;
using WA.ViewModels;
using Microsoft.Extensions.Configuration;
using WA.Data;

namespace WA.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<StoreUser> _signInManager;
        private readonly UserManager<StoreUser> _userManager;
        private readonly IConfiguration _config;
        private readonly WAContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(ILogger<AccountController> logger,
            SignInManager<StoreUser> signInManager,
            UserManager<StoreUser> userManager,
            IConfiguration config,
            WAContext context,
            RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _config = config;
            _context = context;
            _roleManager = roleManager;
        }

        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "App");
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username,
                    model.Password,
                    model.RememberMe,
                    false);
                if (result.Succeeded)
                {
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        Redirect(Request.Query["ReturnUrl"].First());
                    }
                    else
                    {
                        return RedirectToAction("Index", "App");
                    }
                }
            }
            else
            ModelState.AddModelError("", "Failed to login");
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "App");
        }

        [HttpGet("Register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(Register model)
        {

            if (ModelState.IsValid)
            {

                var user = await _userManager.FindByEmailAsync(model.Email);

                if (user == null)
                {
                    user = new StoreUser()
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        UserName = model.UserName,
                        Email = model.Email
                    };
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result != IdentityResult.Success)
                    {
                        string ErrorString = "\n";
                        foreach (var error in result.Errors)
                        {
                            ErrorString += error.Description + "\n";
                        }
                        ViewBag.UserMessage = "Failed to register user:" + ErrorString;
                    }
                    else
                    {
                        ViewBag.UserMessage = "Registration complete.";

                        bool x = await _roleManager.RoleExistsAsync("Users");
                        if (x)
                        {
                            var result1 = await _userManager.AddToRoleAsync(user, "Users");
                        }
                    }
                }
                ModelState.Clear();
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateToken([FromBody] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Username);
                if (user != null)
                {
                    var result = await _signInManager.CheckPasswordSignInAsync(user,
                        model.Password, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        var claims = new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName)
                        };

                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                        var token = new JwtSecurityToken(
                            _config["Tokens:Issuer"],
                            _config["Tokens:Audience"],
                            claims,
                            expires: DateTime.UtcNow.AddMinutes(20),
                            signingCredentials: creds
                            );
                        var results = new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            expiration = token.ValidTo
                        };
                        return Created("", results);
                    }
                }
            }
            return BadRequest();
        }
    }
}
