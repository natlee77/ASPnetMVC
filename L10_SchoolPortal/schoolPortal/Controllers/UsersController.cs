using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
      
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public UsersController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {

            //ViewBag.Users = await _identityService.GetAllUsersWithRolesAsync();
            //ViewBag.Roles = _identityService.GetAllRoles();
            ViewBag.Admins = await _userManager.GetUsersInRoleAsync("Admin");
            ViewBag.Teachers = await _userManager.GetUsersInRoleAsync("Teacher");
            ViewBag.Students = await _userManager.GetUsersInRoleAsync("Students");
            return View();// skapa view på det
            ////list med   users 
            //var userlist = new List<UserViewModel>();
            //var users = _userManager.Users;
            //foreach (var user in users)
            //{
            //    var roles = await _userManager.GetRolesAsync(user);
            //    userlist.Add(new UserViewModel 
            //    {
            //        Id=user.Id,
            //        FirstName=user.FirstName,
            //        LastName=user.LastName,
            //        Email=user.Email,
            //        Role=roles.FirstOrDefault()//first värde from role-list till 1 use // roles.Where(x=> x.   )
            //    });
            //}
            //return View(userlist);  //++view
          
        }

        public IActionResult Create( )
        {
            
            ViewBag.Roles = _roleManager.Roles;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName =model.FirstName,
                    LastName =model.LastName
                };
                var result = await _userManager.CreateAsync(user, "BytMig123!");//model.Password



                if (result.Succeeded)
                {                  
                    await _userManager.AddToRoleAsync(user, model.Role);
                    
                    return RedirectToAction("Index", "Users");
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
