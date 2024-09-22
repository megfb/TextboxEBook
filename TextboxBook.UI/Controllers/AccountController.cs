using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TextbokBook.Business.Abstract;
using TextboxBook.UI.Identity;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.Controllers
{
    [AllowAnonymous]

    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private RoleManager<ApplicationRole> _roleManager;
        private ICountryService _countryService;
        private IGenderService _genderService;
        private ICartService _cartService;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager,ICountryService countryService,IGenderService genderService,ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _countryService = countryService;
            _genderService = genderService;
            _cartService = cartService;
        }
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Home");
            }

            var model = new RegisterViewModel()
            {
                Country = _countryService.GetAll(),
                Gender = _genderService.GetAll()

            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {


            if (!ModelState.IsValid)
            {
                return View(registerViewModel);
            }
            var user = new ApplicationUser()
            {
                UserName = registerViewModel.EMail,
                Name = registerViewModel.Name,
                Surname = registerViewModel.Surname,
                Age = registerViewModel.Age,
                GenderId = registerViewModel.GenderId,
                CountryId = registerViewModel.CountryId,
                Email = registerViewModel.EMail,
            };
            var result = _userManager.CreateAsync(user, registerViewModel.Password).Result;
            if (result.Succeeded)
            {

                if (!_roleManager.RoleExistsAsync("User").Result)
                {
                    ApplicationRole role = new ApplicationRole()
                    {
                        Name = "Admin"
                    };
                    IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
                }
                _userManager.AddToRoleAsync(user, "User").Wait();
                _cartService.InitilaizeCart(user.Id);
                
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(new LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {

            var user = await _userManager.FindByEmailAsync(loginViewModel.EMail);
            if (user == null)
            {
                TempData.Add("Alert", "User is not found");
                return View(loginViewModel);
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);

            if (result.Succeeded)
            {
                TempData.Add("Success", $"Welcome {user.Name}");
                return RedirectToAction("Index", "Home");
            }

            TempData.Add("Alert", "E-Mail or Password is wrong");
            return View(loginViewModel);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
