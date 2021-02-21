using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepDepInjAndPartialView.Models
{
    public class ProductCarouselViewModel
    {

        public string Title { get; set; }
        public List<Product> Products { get; set; }

        //skapa new model from det--> shared/+View partial
    }
}
