using PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialView.Services
{
    public class ProductService : IProductService
    {//här ska göra--DB anropp

        private List<Product> _products;
        public ProductService()
        {
            _products = new List<Product>()
            {
                new Product("Product 1", 1000),
                new Product("Product 2 ", 888),
                new Product("Product 3", 666)
            };
        }




        Product IProductService.GetProduct(string id) //hämta1
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product>  GetProducts()
        {
            return _products;
        }
    }
}
