using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Order
    {
        public string Id { get; set; }

        [Display(Name = "User Id")]
        public string UserId { get; set; }
    }
}
