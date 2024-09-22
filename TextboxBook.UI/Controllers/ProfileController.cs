using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TextbokBook.Business.Abstract;
using TextboxBook.UI.Identity;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.Controllers
{

    [Authorize]
    public class ProfileController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;
        private SignInManager<ApplicationUser> _signInManager;
        private ICountryService _countryService;
        private IGenderService _genderService;
        private ICommentService _commentService;

        public ProfileController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, SignInManager<ApplicationUser> signInManager, ICountryService countryService, IGenderService genderService, ICommentService commentService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _countryService = countryService;
            _genderService = genderService;
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> MyProfile()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            
            var model = new MyProfileViewModel()
            {
                User = user,
                Countrys = _countryService.GetAll(),
                Genders = _genderService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> MyProfile(MyProfileViewModel myProfileViewModel)
        {
            string profileUrl = "myprofile" + "/" + myProfileViewModel.User.Id;
            var getUser = await _userManager.FindByIdAsync(myProfileViewModel.User.Id);
            if (ModelState.IsValid)
            {
                try
                {
                    getUser.Name = myProfileViewModel.User.Name;
                    getUser.Surname = myProfileViewModel.User.Surname;
                    getUser.Email = myProfileViewModel.User.Email;
                    getUser.UserName = myProfileViewModel.User.Email;
                    getUser.NormalizedEmail = myProfileViewModel.User.Email.ToUpper();
                    getUser.NormalizedUserName = myProfileViewModel.User.Email.ToUpper();
                    getUser.Age = myProfileViewModel.User.Age;
                    getUser.GenderId = myProfileViewModel.User.GenderId;
                    getUser.CountryId = myProfileViewModel.User.CountryId;
                    IdentityResult result = await _userManager.UpdateAsync(getUser);
                    TempData.Add("Success", "Profile Updated");
                    return RedirectToAction("index", "Home");

                }
                catch (Exception)
                {
                    TempData.Add("Alert", "Error");
                    return Redirect(profileUrl);
                }
            }
            TempData.Add("Alert", "Error");
            return Redirect(profileUrl);
        }

        public IActionResult ChangePassword()
        {
            return View(new ChangePasswordViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {

            var user = await _userManager.GetUserAsync(HttpContext.User);
            string profileUrl = "myprofile/" + user.Id;
            await _userManager.ChangePasswordAsync(user, changePasswordViewModel.OldPassword, changePasswordViewModel.NewPassword);
            IdentityResult result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return Redirect(profileUrl);
            }

            return View();
        }
        public async Task<IActionResult> DeleteMyAccount()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            await _signInManager.SignOutAsync();
            await _userManager.DeleteAsync(user);
            return RedirectToAction("index", "home");
        }

        public IActionResult CommentHistory()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;

            var model = new CommentHistoryViewModel()
            {
                Comments = _commentService.GetByUserId(user.Id),
            };
            return View(model);
        }

        public ActionResult DeleteComment(int Id)
        {
            _commentService.Delete(Id);
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("commentslist", "Admin");
            }
            return RedirectToAction("commenthistory");
        }
    }
}
