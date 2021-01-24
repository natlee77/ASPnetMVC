using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialView.Models
{
    public class Product
    {
        public Product()
        {

        }
        public Product( string name, double price)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
        }

        public string   Id { get;   set; }
        public string Name { get; set; }
        public double Price { get; set; }



    }
}
