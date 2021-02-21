using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalIdentity.Data
{
    public class AppUser : IdentityUser
    {

        //++Egna saker :
        [PersonalData]
        [Column(TypeName ="nvarchar(50)")]
        [Required]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string LastName { get; set; }


        //public class adress --kan skapa
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }

        [Column(TypeName = "char(5)")]
        public string ZipCode { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }

    }
}
