using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using ControllerAndActions.Infrastructure;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ControllerAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult FormIndex() => View("SimpleForm");

        //public IActionResult ReceiveForm(string name, string city) {
        //    return new CustomHtmlResult() { Content = $"{name} lives in {city}" };
        //}
        [HttpPost]
        public RedirectToActionResult ReceiveForm(string name, string city)
        {
            TempData["name"] = name;
            TempData["city"] = city;
            return RedirectToAction(nameof(Data));
        }

        public ViewResult Data()
        {
            string name = TempData["name"] as string;
            string city = TempData["city"] as string;
          return  View("Result", $"{name} lives in {city}");
        }

        public JsonResult IndexJson() => Json(new[] { "Alice" , "Bob", "Joe"});

       
    }
}
