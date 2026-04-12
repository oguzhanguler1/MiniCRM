using MiniCRM.Models;
using Microsoft.EntityFrameworkCore;

namespace MiniCRM.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Database=Deneme;Username=postgres;Password=1812"
            );
        }

    }
}
