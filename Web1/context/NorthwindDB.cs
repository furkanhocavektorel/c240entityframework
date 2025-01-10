using Microsoft.EntityFrameworkCore;
using Web1.entity;

namespace Web1.context
{
    public class NorthwindDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
                optionsBuilder.
                              UseSqlServer("server=localhost;" +
                              "database=Northwind;" +
                              "Trusted_connection=true;" +
                              "TrustServerCertificate=True; ");
       
         
          
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
