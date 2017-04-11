using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithVisualstudio.Models
{
    public class SimpleRepository: IRepository
    {
        private static SimpleRepository sharedrepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static SimpleRepository SharedRepoistory => sharedrepository;

        public SimpleRepository() {
            var initialItems = new[] {
                new Product { Name = "Kayak", Price=275m},
                new Product { Name = "LifeJacket", Price=48.5m},
                new Product { Name = "Soccer ball", Price=32.5m},
                new Product { Name = "Flag", Price=12.03m}
            };
            foreach (var p in initialItems)
            {
                AddProduct(p);
            }
            products.Add("Error", null);
        }

        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p);
        

        
    }
}
