using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LanguageFeatures.Controllers
{



    public class HomeController : Controller
    {
        bool FilterByPrice(Product p)
        {
            return (p?.Price ?? 0) >= 20;
        }


        public ViewResult IndexOld()
        {
            List<string> results = new List<string>();
            foreach (Product p in Product.GetProduct())
            {
                string name = p?.Name ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
 //               results.Add(string.Format("Name:{0}, Price:{1}, Related:{2}",name,price, relatedName));
                results.Add($"Name: {name}, Price:{price:c2}, Related:{relatedName}");
            }



            ShopingCart cart = new ShopingCart() {Products=Product.GetProduct() };
            



            Product[] productArray =
            {
                new Product {Name="Kayak",Price=25.5m },
                new Product { Name="LifeJacket", Price=90.5m},
                 new Product { Name="SoccerBall", Price=19.5m},
                  new Product { Name="LifeJackfsdaet", Price=34.5m}
            };
            decimal cartTotal = cart.TotalPrices();

           

            Func<Product, bool> nameFilter = delegate (Product prod) {
                return prod?.Name[0] == 'S';
            };


            decimal arrayTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20 ).TotalPrices();
            decimal nameTotal = productArray.Filter(x => x?.Name?[0] == 'S').TotalPrices();

            return View(new string[] {$"Total is : {cartTotal:c2}" , $"Array Total: {arrayTotal:c2}" , $"String Total: {nameTotal:c2}"});
        }


        public ViewResult Index() {
            var products = new[] {
            new  { Name = "Kayak", Price = 275M },
            new { Name = "Lifejacket", Price = 48.95M },
            new { Name = "Soccer ball", Price = 19.50M },
            new  { Name = "Corner flag", Price = 34.95M }
            };

          //  return View(products.Select(p => $"Name is:{p.Name} , Price is :{p.Price}" ));
            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name} , {nameof(p.Price)} is :{p.Price}"));

        }
        public async Task<ViewResult> Index3() {
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"length is {length}" });
        }
        
    }
}
