using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace schoolPortal.Data
{
    public class AppUserClaims : UserClaimsPrincipalFactory<AppUser>
    {
        public AppUserClaims(
            UserManager<AppUser> userManager, 
            IOptions<IdentityOptions> optionsAccessor
            ) : base(userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
        {
            var roles = await UserManager.GetRolesAsync(user);//list roles som user ska hämta
            var _identity=await base.GenerateClaimsAsync(user);
            _identity.AddClaim(new Claim("DisplayName", user.DisplayName));
            _identity.AddClaim(new Claim(ClaimTypes.Role, roles.FirstOrDefault()));
            return _identity;
        }
    }
}
