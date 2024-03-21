using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PermissionManagement.MVC.Entities;

namespace PermissionManagement.MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new[]
                {
                    new Category {Id=1, Name = "Electric" },
                    new Category {Id=2, Name = "Appliances" }
                });
            builder.Entity<Product>().HasData(
                new[]
                {
                    new Product {Id=1,  Name = "Tv", Description = "50 inch TV", Price = 20000, CategoryId = 1 },
                    new Product {Id=2,  Name = "Oven", Description = "Electric Oven", Price = 15000, CategoryId = 1 },
                    new Product {Id=3, Name = "Fridge", Description = "20 feet samsung fridge", Price = 25000, CategoryId = 1 }
                });
            base.OnModelCreating(builder);
        }
    }
}