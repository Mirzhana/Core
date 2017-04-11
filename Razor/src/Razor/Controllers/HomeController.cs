using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index()
        {
            Product myProduct = new Product {
                ProductID = 1,
                Name = "Kayak",
                Description = "a boat",
                Category = "WaterSports",
                Price = 432.3m
            };
            ViewBag.Stock = 0;
            return View(myProduct);
        }
    }
}
