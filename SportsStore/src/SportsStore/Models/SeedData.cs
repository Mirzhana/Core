using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Kayak", Description = "A boat for one person", Category = "Watersports", Price = 275 },
                    new Product { Name = "LifeJacket", Description = "Protective", Category = "Watersports", Price = 48.95m },
                    new Product { Name = "Soccer Ball", Description = "FIFA Approved", Category = "Soccer", Price = 19.50m },
                    new Product { Name = "Corner Flags", Description = "Playing Field", Category = "Soccer", Price = 34.95m },
                    new Product { Name = "Stadium", Description = "35000-seat Stadium", Category = "Soccer", Price = 79500 },
                    new Product { Name = "Thinking Cap", Description = "To Think", Category = "Chess", Price = 16 },
                    new Product { Name = "Unsteady Chair", Description = "To disadvantage opponent", Category = "Chess", Price = 29.95m },
                    new Product { Name = "human Chess Board", Description = "To have fun", Category = "Chess", Price = 75 },
                    new Product { Name = "Bling Blink King", Description = "The King", Category = "Chess", Price = 1200 }
                    );
                context.SaveChanges();
            }
        }
    }
}
