using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
 
        public ViewResult Index() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(Index)});

        public ViewResult CustomVariable(string id) {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(CustomerController)
            };
            r.Data["id"] = id ?? "<no value>";
            r.Data["url"] = Url.Action("CustomVariable", "Home", new {id = 100 });
            return View("Result", r);
        }

    }
}
