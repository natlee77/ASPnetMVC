using RepDepInjAndPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepDepInjAndPartialView.Services
{
    public interface IProductService
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetBestSellers();
        IEnumerable<Product> GetLatest();        
    }
}
