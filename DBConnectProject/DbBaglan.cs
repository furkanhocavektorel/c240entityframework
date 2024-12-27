
using Microsoft.EntityFrameworkCore;

namespace DBConnectProject
{
    internal class DbBaglan : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {// LAB203-OGRETMEN
            // docker:
            // server=localhost;database=c240;uId=sa;password=Password1234
            // server= localhost yazımı sorun çıkartabilir o zaman
            // server= diyip db de ki properties-> name alanı yazılmalı
            optionsBuilder.
                UseSqlServer("server=localhost;" +
                "database=c240;" +
                "Trusted_connection=true;" +
                "TrustServerCertificate=True; ");
        }
        public DbSet<Customers> Customers { get; set; }



    }
}
