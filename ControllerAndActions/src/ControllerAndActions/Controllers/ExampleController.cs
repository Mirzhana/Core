using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ControllerAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public StatusCodeResult Index() => NotFound();
    }
}
