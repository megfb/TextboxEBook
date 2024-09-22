using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TextboxBook.UI.Identity;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.Controllers
{
    [Authorize(Roles = "Admin")]

    public class RoleController : Controller
    {
        private RoleManager<ApplicationRole> _roleManager;

        public RoleController(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult NewRole()
        {

            return View(new RoleAddViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> NewRole(RoleAddViewModel roleAddViewModel)
        {
            IdentityResult result = await _roleManager.CreateAsync(new ApplicationRole { Name = roleAddViewModel.RoleName });
            if (result.Succeeded)
            {
                TempData.Add("Success", "Role added");
                return RedirectToAction("NewRole");
            }


            return View(roleAddViewModel);
        }

        public IActionResult RoleList()
        {
            var roles = new RoleListViewModel()
            {
                GetRoles = _roleManager.Roles.ToList()
            };

            return View(roles);
        }

        [HttpGet]
        public IActionResult UpdateRole(string id)
        {
            var model = new RoleUpdateViewModel
            {
                role = _roleManager.FindByIdAsync(id).Result
            };


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleUpdateViewModel roleUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                if (roleUpdateViewModel.role.Name == null)
                {
                    TempData.Add("Alert", "Roll name can't be null");
                    return Redirect(roleUpdateViewModel.role.Id);
                }
                var targetRole = await _roleManager.FindByIdAsync(roleUpdateViewModel.role.Id);
                targetRole.Name = roleUpdateViewModel.role.Name;
                targetRole.NormalizedName = roleUpdateViewModel.role.Name.ToUpper();
                var result = await _roleManager.UpdateAsync(targetRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("rolelist");

                }
            }

            return View(roleUpdateViewModel);
        }

        public async Task<IActionResult> DeleteRole(string id)
        {
            var targetRole = await _roleManager.FindByIdAsync(id);
            var result = await _roleManager.DeleteAsync(targetRole);
            if (result.Succeeded)
            {
                TempData.Add("Success", "Role deleted");
                return RedirectToAction("rolelist");

            }

            TempData.Add("Alert", "Role couldn't delete");
            return RedirectToAction("rolelist");

        }
    }
}
