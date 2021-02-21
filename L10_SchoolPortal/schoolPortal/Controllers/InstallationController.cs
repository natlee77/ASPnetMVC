using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using schoolPortal.Data;
using schoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace schoolPortal.Controllers
{
    public class InstallationController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public InstallationController(
            SignInManager<AppUser> signInManager, 
            RoleManager<IdentityRole> roleManager, 
            UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        
        
        public IActionResult Index()
        {
            if (!_userManager.Users.Any())
                 return View();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<ActionResult> Index(InstallationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser {
                    UserName = "admin@domain.com",
                    Email = "admin@domain.com",
                    FirstName = "Admin",
                    LastName = "Account"
                };
                var result = await _userManager.CreateAsync(user, model.Password);



                if (result.Succeeded) 
                {
                    await _roleManager.CreateAsync(new IdentityRole("Admin"));
                    await _roleManager.CreateAsync(new IdentityRole("Programm Manager"));
                    await _roleManager.CreateAsync(new IdentityRole("Teacher"));
                    await _roleManager.CreateAsync(new IdentityRole("Student"));

                    await _userManager.AddToRoleAsync(user, "Admin");
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }


                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View();
        }
    }
}
