 
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RolesAndPolicy.Data;
using RolesAndPolicy.Models;
using RolesAndPolicy.Services.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolesAndPolicy.Controllers
{

    //[Authorize(Policy = "adminAccess")]
    //[Route("admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
    //[Route("/User")]
    public class UserController : Controller
    {

        //++hämta alla users
        private readonly IIdentityService _identityService;
        


        public UserController(IIdentityService identityService)
        { 
            _identityService = identityService;
           
        }


        // GET: UserController
        public async Task<ActionResult> Index()
        {
            ViewBag.Users = await _identityService.GetAllUsersWithRolesAsync();
            ViewBag.Roles = _identityService.GetAllRoles();

            return View();// skapa view på det
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            var user = new AppUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName //?Email
            };

            await _identityService.CreateNewUserAsync(user, model.Password);

            return RedirectToAction("Index");
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
