using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSales.Infra.Migrations
{
    public partial class restartingMapping : Migration
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
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
                    { 1, new DateTime(2023, 6, 25, 17, 50, 45, 26, DateTimeKind.Local).AddTicks(2683), "195.980.823-00", "Isabella Xavier", null },
                    { 2, new DateTime(2023, 6, 25, 17, 50, 45, 26, DateTimeKind.Local).AddTicks(4262), "663.898.680-57", "Melissa Melo", null },
                    { 3, new DateTime(2023, 6, 25, 17, 50, 45, 26, DateTimeKind.Local).AddTicks(5029), "518.108.324-20", "Isaac Pereira", null },
                    { 4, new DateTime(2023, 6, 25, 17, 50, 45, 26, DateTimeKind.Local).AddTicks(5661), "892.051.392-97", "Nicolas Xavier", null },
                    { 5, new DateTime(2023, 6, 25, 17, 50, 45, 26, DateTimeKind.Local).AddTicks(6309), "995.796.645-60", "Salvador Reis", null },
                    { 6, new DateTime(2023, 6, 25, 17, 50, 45, 26, DateTimeKind.Local).AddTicks(6991), "226.907.589-70", "Pietro Barros", null },
                    { 7, new DateTime(2023, 6, 25, 17, 50, 45, 26, DateTimeKind.Local).AddTicks(7600), "147.155.695-66", "Ana Júlia Moraes", null },
                    { 8, new DateTime(2023, 6, 25, 17, 50, 45, 26, DateTimeKind.Local).AddTicks(8210), "626.372.126-08", "Guilherme Costa", null },
                    { 9, new DateTime(2023, 6, 25, 17, 50, 45, 26, DateTimeKind.Local).AddTicks(8834), "250.489.414-70", "Yuri Carvalho", null },
                    { 10, new DateTime(2023, 6, 25, 17, 50, 45, 26, DateTimeKind.Local).AddTicks(9460), "114.281.319-30", "Lavínia Braga", null },
                    { 11, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(32), "180.862.167-05", "Feliciano Oliveira", null },
                    { 12, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(667), "462.716.462-98", "Joana Melo", null },
                    { 13, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(1246), "312.436.576-34", "Vicente Moreira", null },
                    { 14, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(1823), "747.204.589-63", "Davi Franco", null },
                    { 15, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(2435), "433.866.610-25", "Cecília Nogueira", null },
                    { 16, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(2998), "484.943.245-00", "Lorraine Pereira", null },
                    { 17, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(3587), "727.024.303-41", "Giovanna Barros", null },
                    { 18, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(4137), "546.103.666-06", "Júlia Batista", null },
                    { 19, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(4718), "143.664.451-82", "Sara Barros", null },
                    { 20, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(5319), "214.499.810-89", "Feliciano Martins", null },
                    { 21, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(5883), "042.494.910-56", "Beatriz Moraes", null },
                    { 22, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(6508), "320.483.829-32", "Suélen Pereira", null },
                    { 23, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(7108), "071.244.610-90", "Samuel Martins", null },
                    { 24, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(7879), "637.593.597-01", "Mércia Moreira", null },
                    { 25, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(8475), "078.246.778-42", "Gabriel Oliveira", null },
                    { 26, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(9074), "635.381.705-33", "Lorraine Macedo", null },
                    { 27, new DateTime(2023, 6, 25, 17, 50, 45, 27, DateTimeKind.Local).AddTicks(9709), "969.275.364-69", "Vitor Braga", null },
                    { 28, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(281), "727.591.674-61", "Ana Júlia Souza", null },
                    { 29, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(910), "942.618.748-06", "Samuel Carvalho", null },
                    { 30, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(1493), "884.335.643-74", "Pablo Costa", null },
                    { 31, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(2146), "265.796.482-60", "Ladislau Moraes", null },
                    { 32, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(2772), "188.697.912-03", "Meire Saraiva", null },
                    { 33, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(3375), "099.883.587-09", "Gustavo Oliveira", null },
                    { 34, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(4016), "416.630.516-66", "Lavínia Silva", null },
                    { 35, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(4609), "527.699.664-48", "Núbia Reis", null },
                    { 36, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(5186), "890.955.628-59", "César Saraiva", null },
                    { 37, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(5784), "530.249.930-45", "Luiza Pereira", null },
                    { 38, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(6358), "470.824.331-66", "Frederico Batista", null },
                    { 39, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(6980), "564.486.988-17", "Félix Barros", null },
                    { 40, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(7572), "934.137.372-79", "Calebe Reis", null },
                    { 41, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(8171), "554.638.751-38", "Margarida Barros", null },
                    { 42, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(8770), "172.936.144-70", "Samuel Braga", null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Document", "FullName", "ModifiedAt" },
                values: new object[,]
                {
                    { 43, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(9372), "663.357.002-39", "Marcos Batista", null },
                    { 44, new DateTime(2023, 6, 25, 17, 50, 45, 28, DateTimeKind.Local).AddTicks(9942), "589.886.968-91", "Anthony Costa", null },
                    { 45, new DateTime(2023, 6, 25, 17, 50, 45, 29, DateTimeKind.Local).AddTicks(602), "074.695.580-47", "Maria Helena Melo", null },
                    { 46, new DateTime(2023, 6, 25, 17, 50, 45, 29, DateTimeKind.Local).AddTicks(1186), "843.051.453-83", "Ana Clara Martins", null },
                    { 47, new DateTime(2023, 6, 25, 17, 50, 45, 29, DateTimeKind.Local).AddTicks(1811), "248.935.115-05", "Washington Albuquerque", null },
                    { 48, new DateTime(2023, 6, 25, 17, 50, 45, 29, DateTimeKind.Local).AddTicks(2392), "791.408.890-09", "Maitê Macedo", null },
                    { 49, new DateTime(2023, 6, 25, 17, 50, 45, 29, DateTimeKind.Local).AddTicks(3008), "161.750.730-02", "Célia Souza", null },
                    { 50, new DateTime(2023, 6, 25, 17, 50, 45, 29, DateTimeKind.Local).AddTicks(3607), "809.293.330-80", "Víctor Oliveira", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "ModifiedAt", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7317), "The Football Is Good For Training And Recreational Purposes", null, "Lindo Algodão Calças", 21.75840530093539m, 97 },
                    { 2, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7702), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Impressionante Congelado Camiseta", 94.185503736447529m, 10 },
                    { 3, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7745), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Lindo Aço Salada", 80.251066126857196m, 39 },
                    { 4, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7772), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Rústico Madeira Teclado", 11.469488728779982m, 31 },
                    { 5, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7795), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Feito à mão Plástico Salada", 19.064063576993896m, 15 },
                    { 6, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7816), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Incrível Plástico Mouse", 39.066545651160763m, 63 },
                    { 7, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7865), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, "Prático Macio Teclado", 93.31674988938688m, 29 },
                    { 8, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7893), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, "Genérico Aço Bacon", 61.748992511564995m, 16 },
                    { 9, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7912), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Licenciado Plástico Sapatos", 84.534507562766293m, 35 },
                    { 10, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7932), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Feito à mão Algodão Chapéu", 17.490237370437754m, 24 },
                    { 11, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7950), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Licenciado Borracha Bacon", 32.697640209982681m, 100 },
                    { 12, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7968), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Licenciado Concreto Teclado", 27.954054335247193m, 24 },
                    { 13, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(7988), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Genérico Madeira Cadeira", 32.428889272749331m, 37 },
                    { 14, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8007), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Sem marca Concreto Mesa", 9.9929374198946425m, 78 },
                    { 15, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8025), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Lustroso Algodão Bicicleta", 72.846459740464552m, 40 },
                    { 16, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8047), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Lustroso Granito Camiseta", 61.610668572447928m, 21 },
                    { 17, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8093), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Refinado Congelado Teclado", 37.860232985228026m, 91 },
                    { 18, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8111), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Inteligente Granito Salada", 8.4723497775776773m, 35 },
                    { 19, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8129), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Prático Plástico Chapéu", 89.147253015174232m, 86 },
                    { 20, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8145), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Lustroso Aço Bola", 51.216486191057989m, 81 },
                    { 21, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8163), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Incrível Macio Cadeira", 27.48777699474676m, 39 },
                    { 22, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8179), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, "Feito à mão Congelado Pizza", 49.25546908275016m, 66 },
                    { 23, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8196), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Inteligente Madeira Mesa", 17.27500660774219m, 99 },
                    { 24, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8214), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Genérico Congelado Toalhas", 76.154447332316143m, 12 },
                    { 25, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8231), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Licenciado Concreto Bicicleta", 81.376484572060534m, 73 },
                    { 26, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8274), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Rústico Aço Frango", 7.579274195976724m, 63 },
                    { 27, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8293), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, "Inteligente Granito Toalhas", 5.3227022818459645m, 91 },
                    { 28, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8309), "The Football Is Good For Training And Recreational Purposes", null, "Feito à mão Borracha Salsicha", 62.492468302582372m, 31 },
                    { 29, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8326), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Ergonômico Aço Toalhas", 82.843568247696112m, 59 },
                    { 30, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8344), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Pequeno Aço Salsicha", 57.17181991279177m, 100 },
                    { 31, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8362), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Prático Granito Bola", 51.833355990303403m, 28 },
                    { 32, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8377), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Prático Madeira Teclado", 74.123653176811567m, 11 },
                    { 33, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8394), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Inteligente Metal Toalhas", 67.017722981849848m, 15 },
                    { 34, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8410), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Gostoso Fresco Atum", 77.651604097891273m, 83 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "ModifiedAt", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 35, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8469), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Refinado Congelado Bicicleta", 96.78867842394136m, 94 },
                    { 36, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8487), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Rústico Concreto Sabonete", 6.0013691119128583m, 99 },
                    { 37, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8503), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Gostoso Macio Peixe", 47.803818569993155m, 58 },
                    { 38, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8520), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Pequeno Borracha Teclado", 29.635183544800096m, 43 },
                    { 39, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8535), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Refinado Concreto Frango", 58.126171351433734m, 2 },
                    { 40, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8550), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Licenciado Concreto Mesa", 21.477037422058822m, 28 },
                    { 41, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8566), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Inteligente Borracha Salgadinhos", 3.9351347367425776m, 17 },
                    { 42, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8582), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Genérico Congelado Luvas", 52.367580663533101m, 86 },
                    { 43, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8598), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Inteligente Algodão Teclado", 79.73982273134098m, 58 },
                    { 44, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8640), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Refinado Aço Teclado", 78.739446460436398m, 26 },
                    { 45, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8657), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Rústico Madeira Pizza", 92.969006323203064m, 19 },
                    { 46, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8674), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, "Lindo Borracha Bicicleta", 49.555903273666921m, 56 },
                    { 47, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8690), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Refinado Macio Toalhas", 12.781315867227148m, 8 },
                    { 48, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8706), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Pequeno Madeira Peixe", 3.249999627543613m, 58 },
                    { 49, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8722), "The Football Is Good For Training And Recreational Purposes", null, "Licenciado Macio Salada", 96.765405000368851m, 50 },
                    { 50, new DateTime(2023, 6, 25, 17, 50, 45, 31, DateTimeKind.Local).AddTicks(8737), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Lindo Aço Bacon", 96.987091398668569m, 49 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "ModifiedAt", "ProductId", "ProductPriceAtMoment", "ProductQuantity", "SaleNumber", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(8630), 17, null, 14, 10.690463541285763m, 14, "20230625175045", 149.666489578000682m },
                    { 2, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9043), 9, null, 6, 19.894162884436122m, 16, "20230625175045", 318.306606150977952m },
                    { 3, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9072), 13, null, 8, 15.800478972438193m, 20, "20230625175045", 316.009579448763860m },
                    { 4, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9091), 15, null, 19, 7.657404194726377m, 11, "20230625175045", 84.231446141990147m },
                    { 5, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9107), 11, null, 6, 11.549125107465522m, 13, "20230625175045", 150.138626397051786m },
                    { 6, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9122), 3, null, 11, 2.1868220774745808m, 9, "20230625175045", 19.6813986972712272m },
                    { 7, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9138), 8, null, 13, 5.207494140087989m, 20, "20230625175045", 104.149882801759780m },
                    { 8, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9151), 10, null, 14, 4.790034625853948m, 17, "20230625175045", 81.430588639517116m },
                    { 9, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9165), 20, null, 7, 13.99091360624317m, 17, "20230625175045", 237.84553130613389m },
                    { 10, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9205), 12, null, 18, 13.47399859582507m, 20, "20230625175045", 269.47997191650140m },
                    { 11, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9219), 5, null, 11, 4.164917426250761m, 5, "20230625175045", 20.824587131253805m },
                    { 12, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9232), 7, null, 1, 18.800532885328182m, 16, "20230625175045", 300.808526165250912m },
                    { 13, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9246), 18, null, 11, 3.499324113169555m, 10, "20230625175045", 34.993241131695550m },
                    { 14, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9258), 12, null, 10, 14.954150593526996m, 14, "20230625175045", 209.358108309377944m },
                    { 15, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9273), 12, null, 3, 5.432754145132751m, 8, "20230625175045", 43.462033161062008m },
                    { 16, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9286), 14, null, 20, 14.588025843941795m, 9, "20230625175045", 131.292232595476155m },
                    { 17, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9299), 6, null, 17, 14.060668130742792m, 4, "20230625175045", 56.242672522971168m },
                    { 18, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9312), 13, null, 15, 6.75073547193635m, 8, "20230625175045", 54.00588377549080m },
                    { 19, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9325), 2, null, 3, 18.484123761028869m, 1, "20230625175045", 18.484123761028869m },
                    { 20, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9380), 4, null, 13, 11.293067844244924m, 15, "20230625175045", 169.396017663673860m },
                    { 21, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9394), 4, null, 18, 2.3755305451167928m, 7, "20230625175045", 16.6287138158175496m },
                    { 22, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9407), 12, null, 18, 6.860929827584405m, 16, "20230625175045", 109.774877241350480m },
                    { 23, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9421), 4, null, 1, 6.85771001217027m, 19, "20230625175045", 130.29649023123513m },
                    { 24, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9434), 2, null, 12, 6.590959003024629m, 2, "20230625175045", 13.181918006049258m },
                    { 25, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9447), 17, null, 12, 15.43786269671536m, 3, "20230625175045", 46.31358809014608m },
                    { 26, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9460), 15, null, 3, 15.464437436424303m, 16, "20230625175045", 247.430998982788848m },
                    { 27, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9473), 13, null, 18, 8.988778623457678m, 18, "20230625175045", 161.798015222238204m },
                    { 28, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9486), 19, null, 9, 3.429356845628798m, 18, "20230625175045", 61.728423221318364m },
                    { 29, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9500), 19, null, 4, 6.543338329858119m, 3, "20230625175045", 19.630014989574357m },
                    { 30, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9513), 6, null, 8, 9.092226535734291m, 10, "20230625175045", 90.922265357342910m },
                    { 31, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9553), 17, null, 4, 4.599037682778072m, 15, "20230625175045", 68.985565241671080m },
                    { 32, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9568), 9, null, 2, 2.3031000496035168m, 12, "20230625175045", 27.6372005952422016m },
                    { 33, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9581), 20, null, 5, 4.354455696026397m, 11, "20230625175045", 47.899012656290367m },
                    { 34, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9594), 6, null, 15, 9.603871343994436m, 13, "20230625175045", 124.850327471927668m },
                    { 35, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9607), 8, null, 14, 4.790877282822217m, 18, "20230625175045", 86.235791090799906m },
                    { 36, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9620), 2, null, 16, 6.784399729836513m, 4, "20230625175045", 27.137598919346052m },
                    { 37, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9633), 8, null, 5, 15.030687308908502m, 5, "20230625175045", 75.153436544542510m },
                    { 38, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9647), 3, null, 8, 16.660646444469822m, 5, "20230625175045", 83.303232222349110m },
                    { 39, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9660), 10, null, 18, 12.409200070008031m, 16, "20230625175045", 198.547201120128496m },
                    { 40, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9673), 11, null, 19, 4.167843948465419m, 16, "20230625175045", 66.685503175446704m },
                    { 41, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9711), 3, null, 16, 6.906495532100589m, 5, "20230625175045", 34.532477660502945m },
                    { 42, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9725), 10, null, 20, 13.277443646640038m, 3, "20230625175045", 39.832330939920114m }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "ModifiedAt", "ProductId", "ProductPriceAtMoment", "ProductQuantity", "SaleNumber", "Total" },
                values: new object[,]
                {
                    { 43, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9738), 20, null, 7, 10.890243036624364m, 4, "20230625175045", 43.560972146497456m },
                    { 44, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9751), 1, null, 3, 9.735441477470533m, 7, "20230625175045", 68.148090342293731m },
                    { 45, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9764), 20, null, 12, 17.241114629196428m, 11, "20230625175045", 189.652260921160708m },
                    { 46, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9777), 17, null, 4, 3.935522005266081m, 14, "20230625175045", 55.097308073725134m },
                    { 47, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9789), 4, null, 18, 1.8463664126811453m, 17, "20230625175045", 31.3882290155794701m },
                    { 48, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9802), 2, null, 4, 16.536220158985422m, 10, "20230625175045", 165.362201589854220m },
                    { 49, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9816), 1, null, 19, 13.979189651272466m, 10, "20230625175045", 139.791896512724660m },
                    { 50, new DateTime(2023, 6, 25, 17, 50, 45, 33, DateTimeKind.Local).AddTicks(9829), 19, null, 6, 7.837026085098957m, 13, "20230625175045", 101.881339106286441m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Document",
                table: "Customers",
                column: "Document",
                unique: true);

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
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
