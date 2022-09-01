using Lab2_Images.EntityConfiguration;
using Lab2_Images.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2_Images.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
            
        }

        public DbSet<Images> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration((new ImageConfiguration()));
        }
    }
}
