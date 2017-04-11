using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace ControllerAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ViewResult Index()
        {
            return View("Result", "This is a derived controller");
        }

        public ViewResult Header()
        {
            return View("DictionaryResult", Request.Headers.ToDictionary(k => k.Key, d => d.Value.First()));
        }
    }
}
