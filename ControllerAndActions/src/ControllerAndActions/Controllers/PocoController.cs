using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ControllerAndActions.Controllers
{
    public class PocoController
    {
        [ControllerContext]
        public ControllerContext ControllerContext { get; set; }


        public ViewResult Index()
        {
            return new ViewResult() { ViewName = "Result", ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary()) { Model = "this is a poco controller" } };
        }

        public ViewResult Headers() =>
                                        new ViewResult()
                                        {
                                            ViewName = "DictionaryResult",
                                            ViewData = new ViewDataDictionary(
                                        new EmptyModelMetadataProvider(),
                                        new ModelStateDictionary())
                                            {
                                                Model = ControllerContext.HttpContext.Request.Headers
                                        .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First())
                                            }
                                        };
    }
}
