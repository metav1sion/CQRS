using CQRS.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Dal.Context
{
    public class CQRSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JTNUQFE\\SQLEXPRESS;initial catalog=CQRSDb;integrated security=true"); // Connection String
        }
        public DbSet<Product> Products { get; set; } // Tablo oluşturmak için DbSet sınıfını kullanıyoruz.
        public DbSet<Category> Categories { get; set; } // Tablo oluşturmak için DbSet sınıfını kullanıyoruz.
    }
}
