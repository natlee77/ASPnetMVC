using App_AutoMapp.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_AutoMapp.Controllers
{
    public class UsersController : Controller
    {
        private IMapper _mapper;

        public UsersController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            //när jag hämta info from-mappa user del in
            var user = GetUserDetails();
            var userViewModel = _mapper.Map<UserViewModel>(user);   //använda automapper som DInj (IMapper)


            //var userViewModel = new UserViewModel()
            //{
            //    FirstName = user.FirstName,
            //    LastName=user.LastName,
            //    Email=user.Email            
            //};
             return View(userViewModel);

        }


        //importera User
        private static User GetUserDetails() 
        {
            return new User
            {
                Id = 1,
                FirstName = "Nata",
                LastName = "Lisjö",
                Email = "ooooooo@gmail.com",
                Password = "ooooooooo"
            };
        }




    }
}
