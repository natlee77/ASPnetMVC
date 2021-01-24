using PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialView.Services
{
    public interface IProductService
    {
        //contract---bestämma vilka f. &vad retunera 
        Product GetProduct(string id);
        IEnumerable<Product> GetProducts();


        //++ nån med functionalitet:--> ++class "ProductService"

    }
}
