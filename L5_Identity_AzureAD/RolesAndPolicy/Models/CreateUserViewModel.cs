using RolesAndPolicy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolesAndPolicy.Models
{
    public class CreateUserViewModel : AppUser
    {
        public string Password { get; set; }
    }
}
