using Microsoft.AspNetCore.Mvc;
using RepDepInjAndPartialView.Models;
using RepDepInjAndPartialView.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepDepInjAndPartialView.Controllers
{
    public class ProductsController : Controller
    {
        //DI -indexera controller

        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }



        //action del på INDEX sida
        public IActionResult Index()
        { //ProductsViewModelen är bara för View/lättare att få saker på ett sett in View
          //kan inte importera flera saker i View -->därför göra vi ViewModel


            var viewModel = new ProductsViewModel();
            //viewModel.BestSellers = _productService.GetBestSellers(); //fel IEnum<list>-Generic <list>-->gå ProdViewModel 
            //viewModel.Latest = _productService.GetLatest();

            //new ProductList { Title = "Bestsellers", Items = _productService.GetBestSellers() };
            //new ProductList { Title = "Lastest", Items = _productService.GetLatest() };

            //viewModel.ProductsLists.Add(new ProductsList { Title = "Bestsellers", Items = _productService.GetBestSellers() });
            //viewModel.ProductsLists.Add(new ProductsList { Title = "Lastest", Items = _productService.GetLatest() });
            
            
            //att iniciera instanse:
            viewModel.ProductsLists=new List<ProductList>           
            {
                new ProductList { Title = "Bestsellers", Items = _productService.GetBestSellers() },
                new ProductList { Title = "Lastest", Items = _productService.GetLatest() }
            };


            return View(viewModel.ProductsLists);
            //return View(viewModel);//--->skapa viewModel
        }
    }
}
