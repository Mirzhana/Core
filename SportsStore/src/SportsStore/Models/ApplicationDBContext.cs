using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SportsStore.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

    //public class TemporaryDbContextFactory :IDbContextFactory<DbContext>
    //{
    //    public DbContext Create()
    //    {
    //        var builder = new DbContextOptionsBuilder<DbContext>();
    //        builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SportsStore;Trusted_Connection=True;MultipleActiveResultSets=true");
    //        return new DbContext(builder.Options);
    //    }
    //}


}
