using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialView.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialView.Controllers
{
    public class ProductsController : Controller
    {
        //dj-ctor
        private IProductService _productService { get;   set; }
        //public ProductsController(IProductService productService)
        //{
        //    _productService = productService;
        //}


        //logga -variant
        private readonly ILogger<ProductsController> _logger;
        public ProductsController(IProductService productService, ILogger<ProductsController> logger)
        {
            _productService =  productService;
            _logger = logger;
        }




        public IActionResult Index()
        {
            return View(_productService.GetProducts());    //mappa direct
            //om jag vill sortera/hämta ut visa delar /filtrera--då andra saker här
        }
    }
}
