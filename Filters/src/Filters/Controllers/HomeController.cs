using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Filters.Infrastructure;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860
//https://localhost:44357/
namespace Filters.Controllers
{
    //[Profile]
    //[ViewResultDetails]
    //[RangeException]
    [TypeFilter(typeof(DiagnosticsFilter))]
    [TypeFilter(typeof(TimeFilter))]

    public class HomeController : Controller
    {

        
        public ViewResult Index() => View("Message", "This is the Index Action");
               
        public ViewResult SecondAction() => View("Message","Second Actionn");

        public ViewResult GenerateException(int? id) {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            else if (id > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }
            else {
                return View("Message", "All good");
            }
        }

    }
}
