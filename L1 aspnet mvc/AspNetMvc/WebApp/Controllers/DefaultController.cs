using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
