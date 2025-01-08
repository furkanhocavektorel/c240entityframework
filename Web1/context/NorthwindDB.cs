using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Web1.entity;

namespace Web1.context
{
    public class NorthwindDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.
                              UseSqlServer("server=localhost;" +
                              "database=Northwindd;" +
                              "Trusted_connection=true;" +
                              "TrustServerCertificate=True; ");
            }
            catch (SqlException ex)
            {
                try
                {
                    Console.WriteLine("yedek başlatildi");
                    optionsBuilder.
                                UseSqlServer("server=129.34.56.5;" +
                                "database=Northwindd;" +
                                "Trusted_connection=true;" +
                                "TrustServerCertificate=True; ");
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("yedek başlatildi");
                    optionsBuilder.
                                UseSqlServer("server=129.34.56.5;" +
                                "database=Northwindd;" +
                                "Trusted_connection=true;" +
                                "TrustServerCertificate=True; ");
                }
               
            }
          
        }

        public DbSet<Product> Products { get; set; }

    }
}
