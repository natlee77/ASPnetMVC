using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepDepInjAndPartialView.Models
{
    public class ProductsViewModel
    { //det modelen är bara för View/lättare att få saker på ett sett in View
      //kan inte importera flera saker i View



        //olika category-->controller --> 
        //fel i ProdController -->list--> to IEnurable

        //public IEnumerable<Product> News { get; set; }
        //public IEnumerable<Product> BestSellers { get; set; }
        //public IEnumerable<Product> RecommendetForYou { get; set; }
        //public IEnumerable<Product> Latest { get; set; }
        //public List<Product> News { get; set; }
        //public List<Product> BestSellers { get; set; }
        //public List<Product> RecommendetForYou { get; set; }
        //public List<Product> Latest { get; set; }



       // public ProductList BestSellers { get; set; }
       // public ProductList Latest { get; set; }


        public List<ProductList> ProductsLists { get; set; }//har flexabiletet
    }

    public class ProductList
    {
        public string Title { get; set; }
        public IEnumerable<Product> Items { get; set; }
    }
}
