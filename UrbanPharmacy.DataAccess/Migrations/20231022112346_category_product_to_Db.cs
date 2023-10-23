using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UrbanPharmacy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class category_product_to_Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Prescription Medicine" },
                    { 2, 2, "Over-the-Counter Medicine" },
                    { 3, 3, "Vitamins and Supplements" },
                    { 4, 4, "Health Devices" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "ListPrice", "Name", "Price", "Price100", "Price50", "SKU" },
                values: new object[,]
                {
                    { 1, "PharmaBrand", "Product 1 description.", 99.989999999999995, "Product 1", 89.989999999999995, 79.989999999999995, 84.989999999999995, "PHM0001" },
                    { 2, "PharmaBrand", "Product 2 description.", 49.990000000000002, "Product 2", 39.990000000000002, 29.989999999999998, 34.990000000000002, "PHM0002" },
                    { 3, "PharmaBrand", "Product 3 description.", 59.990000000000002, "Product 3", 49.990000000000002, 39.990000000000002, 44.990000000000002, "PHM0003" },
                    { 4, "PharmaBrand", "Product 4 description.", 79.989999999999995, "Product 4", 69.989999999999995, 59.990000000000002, 64.989999999999995, "PHM0004" },
                    { 5, "PharmaBrand", "Product 5 description.", 69.989999999999995, "Product 5", 59.990000000000002, 49.990000000000002, 54.990000000000002, "PHM0005" },
                    { 6, "PharmaBrand", "Product 6 description.", 89.989999999999995, "Product 6", 79.989999999999995, 69.989999999999995, 74.989999999999995, "PHM0006" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
