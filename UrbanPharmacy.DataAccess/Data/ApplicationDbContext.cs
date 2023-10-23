using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UrbanPharmacy.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UrbanPharmacy.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Prescription Medicine", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Over-the-Counter Medicine", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Vitamins and Supplements", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Health Devices", DisplayOrder = 4 }
            );
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Tech Solution",
                    StreetAddress = "123 Tech St",
                    City = "Tech City",
                    PostalCode = "12121",
                    State = "IL",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Books",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "66666",
                    State = "IL",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "Readers Club",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "99999",
                    State = "NY",
                    PhoneNumber = "1113335555"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Brand = "PharmaBrand",
                    Description = "Product 1 description.",
                    SKU = "PHM0001",
                    ListPrice = 99.99,
                    Price = 89.99,
                    Price50 = 84.99,
                    Price100 = 79.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Brand = "PharmaBrand",
                    Description = "Product 2 description.",
                    SKU = "PHM0002",
                    ListPrice = 49.99,
                    Price = 39.99,
                    Price50 = 34.99,
                    Price100 = 29.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Name = "Product 3",
                    Brand = "PharmaBrand",
                    Description = "Product 3 description.",
                    SKU = "PHM0003",
                    ListPrice = 59.99,
                    Price = 49.99,
                    Price50 = 44.99,
                    Price100 = 39.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Name = "Product 4",
                    Brand = "PharmaBrand",
                    Description = "Product 4 description.",
                    SKU = "PHM0004",
                    ListPrice = 79.99,
                    Price = 69.99,
                    Price50 = 64.99,
                    Price100 = 59.99,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Name = "Product 5",
                    Brand = "PharmaBrand",
                    Description = "Product 5 description.",
                    SKU = "PHM0005",
                    ListPrice = 69.99,
                    Price = 59.99,
                    Price50 = 54.99,
                    Price100 = 49.99,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Name = "Product 6",
                    Brand = "PharmaBrand",
                    Description = "Product 6 description.",
                    SKU = "PHM0006",
                    ListPrice = 89.99,
                    Price = 79.99,
                    Price50 = 74.99,
                    Price100 = 69.99,
                    CategoryId = 3,
                    ImageUrl = ""
                }
            );
        }
    }
}
