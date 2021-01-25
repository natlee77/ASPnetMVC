using App_AutoMapp.Models;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_AutoMapp
{
    public class UserProfile: Profile
    {
        //bygga up hur det ska match olicka del

        public UserProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<User, LoginViewModel>();

        }
    }
}
