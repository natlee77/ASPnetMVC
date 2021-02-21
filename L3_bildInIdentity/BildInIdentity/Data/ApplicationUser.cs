using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BildInIdentity.Data
{
    public class ApplicationUser : IdentityUser
    {
        //hear-- can definera + all I want

        [PersonalData]  //del av GDPR del
        [Column (TypeName="nvarchar(50)")] //tala att FN-type i DB
        public string FirstName { get; set; }


        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        //nu , jag vill applicatDbContext använd it-->
    }
}
