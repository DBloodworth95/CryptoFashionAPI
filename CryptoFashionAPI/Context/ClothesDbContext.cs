using CryptoFashionAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CryptoFashionAPI.Context
{
    public class ClothesDbContext : DbContext
    {
        public DbSet<Shirt> Shirts { get; set; }

        public ClothesDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shirt>().ToTable("Shirts");
        }
    }
}