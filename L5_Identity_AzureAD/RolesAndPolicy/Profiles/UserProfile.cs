using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RolesAndPolicy.Data;
using RolesAndPolicy.Models;

namespace RolesAndPolicy.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() //ska mappa Appuser -> UsreViewModel
        {
            CreateMap<AppUser, UserViewModel>();
            // CreateMap<AppUser, ......ViewModel>();  //flera views
        }
    }
}
