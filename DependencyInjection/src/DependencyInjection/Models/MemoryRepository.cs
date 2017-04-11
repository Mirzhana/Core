using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class MemoryRepository:IRepository
    {
        private IModelStorage storage;
        private string guid = System.Guid.NewGuid().ToString();
        public MemoryRepository(IModelStorage modelStore) {
            storage = modelStore;

            new List<Product> {
                new Product { Name="Kayak" , Price =275m},
                new Product { Name="LifeJacket" , Price =48.95m},
                new Product { Name="Soccer Ball" , Price =19.50m}
            }.ForEach(p => AddProduct(p));

        }

        public IEnumerable<Product> Products => storage.Items;

        public Product this[string name] => storage[name];

        public void AddProduct(Product product) => storage[product.Name] = product;

        public void DeleteProduct(Product product) => storage.RemoveItem(product.Name);

        public override string ToString()
        {
            return guid;
        }



    }
}
