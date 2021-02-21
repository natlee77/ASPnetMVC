using Microsoft.AspNetCore.Mvc;
using RepPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepPartialView.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var model = new ProductsViewModel();

            // model.BestSellers = _ProductService.GetBestSellers();
            // model.RecommendedForYou = _ProductService.GetRecommended(userId);

            return View(model);
        }
    }
}
