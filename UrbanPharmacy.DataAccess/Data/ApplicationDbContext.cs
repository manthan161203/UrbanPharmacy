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
    new Category { Id = 1, Name = "Cardiovascular", DisplayOrder = 1 },
    new Category { Id = 2, Name = "Over-the-Counter Medicine", DisplayOrder = 2 },
    new Category { Id = 3, Name = "Vitamins and Supplements", DisplayOrder = 3 },
    new Category { Id = 4, Name = "Health Devices", DisplayOrder = 4 }
);
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Urban Pharmacy",
                    StreetAddress = "14 jankidas-2, santram deri road",
                    City = "Nadiad",
                    PostalCode = "387002",
                    State = "Gujarat",
                    PhoneNumber = "8787878787"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "CardioShield",
                    Brand = "HeartCare",
                    Description = "CardioShield is a cardiovascular health supplement.",
                    SKU = "HC0001",
                    ListPrice = 39.99,
                    Price = 34.99,
                    Price50 = 32.99,
                    Price100 = 29.99,
                    CategoryId = 1,
                    ImageUrl = "https://urbanclap1.000webhostapp.com/urbanPharmacy/cardioShield.png"
                },

                new Product
                {
                    Id = 2,
                    Name = "Vasodilix",
                    Brand = "VasoHealth",
                    Description = "Vasodilix helps maintain healthy blood vessels.",
                    SKU = "VH0002",
                    ListPrice = 44.99,
                    Price = 39.99,
                    Price50 = 37.99,
                    Price100 = 34.99,
                    CategoryId = 1,
                    ImageUrl = "https://urbanclap1.000webhostapp.com/urbanPharmacy/vasodilix.png"
                },

                new Product
                {
                    Id = 3,
                    Name = "PainRelief",
                    Brand = "PainAway",
                    Description = "PainRelief tablets for quick pain relief.",
                    SKU = "PA0003",
                    ListPrice = 9.99,
                    Price = 7.99,
                    Price50 = 7.49,
                    Price100 = 6.99,
                    CategoryId = 2,
                    ImageUrl = "https://urbanclap1.000webhostapp.com/urbanPharmacy/painRelief.png"
                },
                new Product
                {
                    Id = 4,
                    Name = "ColdBuster",
                    Brand = "ViruShield",
                    Description = "ColdBuster provides relief from cold and flu symptoms.",
                    SKU = "VS0004",
                    ListPrice = 12.99,
                    Price = 10.99,
                    Price50 = 10.49,
                    Price100 = 9.99,
                    CategoryId = 2,
                    ImageUrl = "https://urbanclap1.000webhostapp.com/urbanPharmacy/coldbuster.png"
                },
                new Product
                {
                    Id = 5,
                    Name = "ImmuneBoost",
                    Brand = "ImmunoVital",
                    Description = "ImmuneBoost supports a healthy immune system.",
                    SKU = "IV0005",
                    ListPrice = 19.99,
                    Price = 16.99,
                    Price50 = 15.99,
                    Price100 = 14.99,
                    CategoryId = 3,
                    ImageUrl = "https://urbanclap1.000webhostapp.com/urbanPharmacy/immuneboost.png"
                },
                new Product
                {
                    Id = 6,
                    Name = "VitaMix",
                    Brand = "HealthPlus",
                    Description = "VitaMix is a comprehensive multivitamin supplement.",
                    SKU = "HP0006",
                    ListPrice = 14.99,
                    Price = 12.99,
                    Price50 = 11.99,
                    Price100 = 10.99,
                    CategoryId = 3,
                    ImageUrl = "https://urbanclap1.000webhostapp.com/urbanPharmacy/vitamix.png"
                },
                new Product
                {
                    Id = 7,
                    Name = "VitaGuard",
                    Brand = "ImmunoVital",
                    Description = "VitaGuard supports overall health and immunity.",
                    SKU = "IV0007",
                    ListPrice = 19.99,
                    Price = 16.99,
                    Price50 = 15.99,
                    Price100 = 14.99,
                    CategoryId = 3,
                    ImageUrl = "https://urbanclap1.000webhostapp.com/urbanPharmacy/vitaguard.png"
                },
                new Product
                {
                    Id = 8,
                    Name = "MineralMax",
                    Brand = "HealthPlus",
                    Description = "MineralMax is a mineral and nutrient supplement.",
                    SKU = "HP0008",
                    ListPrice = 14.99,
                    Price = 12.99,
                    Price50 = 11.99,
                    Price100 = 10.99,
                    CategoryId = 3,
                    ImageUrl = "https://urbanclap1.000webhostapp.com/urbanPharmacy/MineralMax.png"
                }
            );
        }
    }
}
