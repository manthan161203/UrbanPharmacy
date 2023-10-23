﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrbanPharmacy.DataAccess.Data;

#nullable disable

namespace UrbanPharmacy.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231022114525_KaiNai")]
    partial class KaiNai
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UrbanPharmacy.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Prescription Medicine"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Over-the-Counter Medicine"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Vitamins and Supplements"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Health Devices"
                        });
                });

            modelBuilder.Entity("UrbanPharmacy.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "PharmaBrand",
                            CategoryId = 1,
                            Description = "Product 1 description.",
                            ImageUrl = "",
                            ListPrice = 99.989999999999995,
                            Name = "Product 1",
                            Price = 89.989999999999995,
                            Price100 = 79.989999999999995,
                            Price50 = 84.989999999999995,
                            SKU = "PHM0001"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "PharmaBrand",
                            CategoryId = 1,
                            Description = "Product 2 description.",
                            ImageUrl = "",
                            ListPrice = 49.990000000000002,
                            Name = "Product 2",
                            Price = 39.990000000000002,
                            Price100 = 29.989999999999998,
                            Price50 = 34.990000000000002,
                            SKU = "PHM0002"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "PharmaBrand",
                            CategoryId = 1,
                            Description = "Product 3 description.",
                            ImageUrl = "",
                            ListPrice = 59.990000000000002,
                            Name = "Product 3",
                            Price = 49.990000000000002,
                            Price100 = 39.990000000000002,
                            Price50 = 44.990000000000002,
                            SKU = "PHM0003"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "PharmaBrand",
                            CategoryId = 2,
                            Description = "Product 4 description.",
                            ImageUrl = "",
                            ListPrice = 79.989999999999995,
                            Name = "Product 4",
                            Price = 69.989999999999995,
                            Price100 = 59.990000000000002,
                            Price50 = 64.989999999999995,
                            SKU = "PHM0004"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "PharmaBrand",
                            CategoryId = 2,
                            Description = "Product 5 description.",
                            ImageUrl = "",
                            ListPrice = 69.989999999999995,
                            Name = "Product 5",
                            Price = 59.990000000000002,
                            Price100 = 49.990000000000002,
                            Price50 = 54.990000000000002,
                            SKU = "PHM0005"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "PharmaBrand",
                            CategoryId = 3,
                            Description = "Product 6 description.",
                            ImageUrl = "",
                            ListPrice = 89.989999999999995,
                            Name = "Product 6",
                            Price = 79.989999999999995,
                            Price100 = 69.989999999999995,
                            Price50 = 74.989999999999995,
                            SKU = "PHM0006"
                        });
                });

            modelBuilder.Entity("UrbanPharmacy.Models.Product", b =>
                {
                    b.HasOne("UrbanPharmacy.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
