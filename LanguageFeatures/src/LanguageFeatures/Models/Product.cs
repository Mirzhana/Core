using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            this.InStock = stock;
        }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public string Category { get; set; } = "Watersports";
        public bool InStock { get; } = true;

        public bool NameBeginsWithS => Name?[0] == 'S';

        public static Product[] GetProduct()
        {
            Product kayak = new Product(false) { Name="Kayak", Price=275, Category="water craft" };
            Product lifeJacket = new Product { Name="Life Jacket",Price=48.95m};
            kayak.Related = lifeJacket;
            return new Product[] { kayak, lifeJacket, null };
        }
    }
}
