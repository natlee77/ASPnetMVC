using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RolesAndPolicy.Data
{
    public class AppUserClaims : UserClaimsPrincipalFactory<AppUser, IdentityRole>
    {

        //private readonly UserManager<AppUser> _userManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        //ctor
        public AppUserClaims(
            UserManager<AppUser> userManager, 
            RoleManager<IdentityRole> roleManager, 
            IOptions<IdentityOptions> options) 
            : base(userManager, roleManager, options)//abstract-i C#/skicka managers till ->base UserClaimsPrincipalFactory
        {
            //_userManager = userManager;
            //_roleManager = roleManager;
        }
        //override -det skapar id , username/som kan!bryta . kan lägga till de 
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
        {        //ordning , 
            var _identity=await base.GenerateClaimsAsync(user);//-standart generera  base Claims

            ////byggat på den->rolen
            //var _userRoles = await _userManager.GetRolesAsync(user);
            //var _userRole = _userRoles.FirstOrDefault();//söka vilken role har 

            //extra-egna claims   --key<->value par
            _identity.AddClaim(new Claim("FirstName" , user.FirstName ??""));//om det tomt?? generera tomt
            _identity.AddClaim(new Claim("LastName" , user.LastName ?? ""));
            _identity.AddClaim(new Claim("DisplayName" ,$"{user.FirstName} {user.LastName}" ??""));


            //_identity.AddClaim(new Claim("DisplayName", user.GetDisplayName() ?? ""));
            //  _identity.AddClaim(new Claim("Role", _userRole));//1role , flera behovs array
            return _identity;
        }
    }
}
