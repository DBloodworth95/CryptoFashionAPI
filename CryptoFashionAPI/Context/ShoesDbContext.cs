using CryptoFashionAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CryptoFashionAPI.Context
{
    public class ShoesDbContext : DbContext
    {
        public DbSet<Shoe> Shoes { get; set; }

        public ShoesDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shoe>().ToTable("Shoes");
        }
    }
}