using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepPartialView.Models
{
    public class ProductsViewModel
    {
        public List<Product> News { get; set; }
        public List<Product> BestSellers { get; set; }
        public List<Product> RecommendedForYou { get; set; }
        public List<Product> Campaign { get; set; }
    }
}
