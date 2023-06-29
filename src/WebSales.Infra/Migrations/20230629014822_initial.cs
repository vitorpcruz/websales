using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSales.Infra.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Document = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: false),
                    IsLegalPerson = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleNumber = table.Column<string>(type: "char(14)", maxLength: 14, nullable: false),
                    ProductPriceAtMoment = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    SaleCancelled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Document", "FullName", "ModifiedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(5430), "382.152.203-80", "Isabela Saraiva", null },
                    { 2, new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(6894), "852.628.770-28", "Matheus Oliveira", null },
                    { 3, new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(7618), "942.456.367-18", "Félix Albuquerque", null },
                    { 4, new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(8305), "070.495.427-33", "Víctor Pereira", null },
                    { 5, new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(8918), "883.604.630-42", "Hélio Macedo", null },
                    { 6, new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(9526), "031.553.809-00", "Margarida Melo", null },
                    { 7, new DateTime(2023, 6, 28, 22, 48, 22, 243, DateTimeKind.Local).AddTicks(128), "697.970.771-01", "João Miguel Braga", null },
                    { 8, new DateTime(2023, 6, 28, 22, 48, 22, 243, DateTimeKind.Local).AddTicks(757), "213.674.466-60", "Yago Santos", null },
                    { 9, new DateTime(2023, 6, 28, 22, 48, 22, 243, DateTimeKind.Local).AddTicks(1369), "992.035.824-01", "Marli Franco", null },
                    { 10, new DateTime(2023, 6, 28, 22, 48, 22, 243, DateTimeKind.Local).AddTicks(1944), "430.282.699-10", "Célia Moreira", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "Description", "ModifiedAt", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(4954), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, "Genérico Borracha Toalhas", 11.365512587310034m, 45 },
                    { 2, new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5258), null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Sem marca Aço Calças", 44.227627758033895m, 91 },
                    { 3, new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5293), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Licenciado Plástico Bola", 32.776356910107304m, 82 },
                    { 4, new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5317), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, "Rústico Fresco Pizza", 70.388869774976092m, 55 },
                    { 5, new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5342), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, "Feito à mão Fresco Toalhas", 50.146406511197644m, 97 },
                    { 6, new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5391), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Lustroso Aço Calças", 42.049319724685558m, 31 },
                    { 7, new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5412), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Feito à mão Fresco Bicicleta", 71.075760385589695m, 69 },
                    { 8, new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5429), null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Rústico Macio Camiseta", 87.223846591226476m, 30 },
                    { 9, new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5448), null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Prático Macio Mouse", 89.196131279344429m, 36 },
                    { 10, new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5465), null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Impressionante Madeira Salgadinhos", 76.021604075099836m, 29 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Document",
                table: "Customers",
                column: "Document",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CustomerId",
                table: "Products",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
