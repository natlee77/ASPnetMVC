using Microsoft.AspNetCore.Identity;
using RolesAndPolicy.Data;
using RolesAndPolicy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolesAndPolicy.Services.Identity
{
     public interface IIdentityService
     {
         Task CreateRootAccountAsync();

        Task CreateNewRole(string roleName);

        Task<IdentityResult> CreateNewUserAsync(AppUser user, string password);

        Task AddUserToRole(AppUser user, string roleName);

        IEnumerable<AppUser> GetAllUsers();//hämta alla user

        IEnumerable<IdentityRole> GetAllRoles();

        Task<IEnumerable<UserViewModel> >GetAllUsersWithRolesAsync();
       
    }
}
