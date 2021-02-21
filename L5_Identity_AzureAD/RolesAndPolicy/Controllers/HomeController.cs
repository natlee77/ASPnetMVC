using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RolesAndPolicy.Data;
using RolesAndPolicy.Models;
using RolesAndPolicy.Services.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RolesAndPolicy.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {   
       
        private readonly ILogger<HomeController> _logger;

        
        private readonly IIdentityService _identityService;

        public HomeController(
            ILogger<HomeController> logger,            
            IIdentityService identityService)
        {
            _logger = logger;           
            _identityService = identityService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            //if (!_userManager.Users.Any())  //skapa user-admin
            //{
            //    var user = new AppUser() { UserName = "admin" , Email= "admin@domain.com" };
            //    var result=await _userManager.CreateAsync(user, "BytMig123!");

            //    if(result.Succeeded)
            //    {
            //        if (!_roleManager.Roles.Any())
            //        {
            //            await _roleManager.CreateAsync(new IdentityRole("Admin"));
            //            await _roleManager.CreateAsync(new IdentityRole("User"));

            //        }
            //        await _roleManager.CreateAsync(new IdentityRole("Admin"));
            //    }
            //}



            await _identityService.CreateRootAccountAsync();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }



        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
