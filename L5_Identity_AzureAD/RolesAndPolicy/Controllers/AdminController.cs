using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RolesAndPolicy.Data;
using RolesAndPolicy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolesAndPolicy.Controllers
{
    [Authorize  ( Policy  = "adminAccess")]//

    public class AdminController : Controller
    {
        //DI
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public AdminController(UserManager<AppUser> userManager,   RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _userManager = userManager;   //-->users() -hämta users in lista
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            //var users = _userManager.Users.ToList();
            return View();
        }
        public async Task<IActionResult> Users()
        {
            var users = _userManager.Users.ToList();  //hämta i list


            //skapa new form utav object, som jag kan göra nånt://jag vill ser/add/packetera role

            var userlist = new List<UserViewModel>();
            foreach (var user in users)
            {
                //1-skapa new Model=UserViewModel//2.install automapåper/3. DI-mapper
                // + new object --/ automapper-perfect for nån andring nånstance


                userlist.Add(_mapper.Map<UserViewModel>(user));

            }
            //+jag vill ha andra saker init
            
            foreach (var user in userlist)
            {
                 user.Roles = await _userManager.GetRolesAsync(user);
            }
            return View(userlist);                       //stoppa list i view

        }
       

          
           
     

        public IActionResult Roles()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }






        [Route("admin/users/create")]    //skapa fin link
        //skapa roles /1 view- tomt formular (get)/2-när tryck add->post på den formular->
        [HttpGet]
        public IActionResult CreateRole() //get
        {           
            return View(new IdentityRole());  //skapa   object 
        }
        [Route("admin/users/create")]
        [HttpPost]
        public async Task<IActionResult> CreateRole(IdentityRole role)  //2.post tar den   object
        {
            await _roleManager.CreateAsync(role);//skapa role
            return RedirectToAction("Roles");//redirect to Roles()
        }



       
        //public IActionResult CreateUsers()
        //{
        //    return View();
        //}
    }
}
