using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSales.Infra.Migrations
{
    public partial class reapplyingMigraitons : Migration
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
                    { 1, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(1756), "424.030.661-25", "Cauã Carvalho", null },
                    { 2, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(3145), "982.928.763-75", "Fabrício Macedo", null },
                    { 3, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(3900), "628.810.506-62", "Lorraine Nogueira", null },
                    { 4, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(4542), "649.804.469-14", "Hugo Martins", null },
                    { 5, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(5160), "388.272.557-53", "Yasmin Carvalho", null },
                    { 6, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(5911), "597.065.680-18", "Alessandra Franco", null },
                    { 7, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(6548), "809.012.755-06", "Ígor Santos", null },
                    { 8, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(7161), "564.095.429-92", "Guilherme Batista", null },
                    { 9, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(7873), "072.324.358-19", "Antonella Reis", null },
                    { 10, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(8482), "254.784.466-45", "Cecília Albuquerque", null },
                    { 11, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(9022), "017.089.845-85", "Lucca Saraiva", null },
                    { 12, new DateTime(2023, 6, 28, 8, 26, 32, 525, DateTimeKind.Local).AddTicks(9648), "078.252.877-54", "Enzo Silva", null },
                    { 13, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(186), "346.433.737-50", "Maria Luiza Saraiva", null },
                    { 14, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(731), "851.567.451-30", "Marcos Braga", null },
                    { 15, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(1362), "167.475.746-80", "Leonardo Nogueira", null },
                    { 16, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(1963), "256.053.740-01", "César Nogueira", null },
                    { 17, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(2490), "215.327.505-95", "Maria Eduarda Barros", null },
                    { 18, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(3108), "483.357.938-32", "Mariana Macedo", null },
                    { 19, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(3689), "409.190.461-00", "Paula Oliveira", null },
                    { 20, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(4289), "676.714.990-05", "Calebe Moreira", null },
                    { 21, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(4835), "233.331.438-95", "Eduardo Albuquerque", null },
                    { 22, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(5426), "596.675.213-38", "Márcia Xavier", null },
                    { 23, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(6024), "911.522.768-59", "Valentina Braga", null },
                    { 24, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(6617), "953.918.468-11", "Félix Melo", null },
                    { 25, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(7157), "056.750.626-61", "Dalila Melo", null },
                    { 26, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(7741), "999.200.108-98", "Noah Braga", null },
                    { 27, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(8284), "166.655.046-97", "Alexandre Reis", null },
                    { 28, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(8851), "943.625.710-43", "Leonardo Macedo", null },
                    { 29, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(9431), "404.856.622-99", "Elísio Costa", null },
                    { 30, new DateTime(2023, 6, 28, 8, 26, 32, 526, DateTimeKind.Local).AddTicks(9977), "220.605.613-53", "Yago Carvalho", null },
                    { 31, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(589), "111.999.601-52", "Matheus Santos", null },
                    { 32, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(1128), "263.477.590-39", "Antonella Albuquerque", null },
                    { 33, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(1682), "979.776.586-58", "Manuela Melo", null },
                    { 34, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(2228), "740.455.297-48", "Benjamin Costa", null },
                    { 35, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(2823), "511.587.408-32", "Isaac Saraiva", null },
                    { 36, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(3375), "667.104.484-87", "Bernardo Saraiva", null },
                    { 37, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(3931), "462.614.142-03", "Yango Barros", null },
                    { 38, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(4497), "794.189.137-98", "Gael Macedo", null },
                    { 39, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(5047), "124.783.458-11", "Yago Braga", null },
                    { 40, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(5596), "339.128.819-10", "Silas Melo", null },
                    { 41, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(6185), "644.687.381-62", "João Carvalho", null },
                    { 42, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(6710), "091.768.631-40", "Fabrício Carvalho", null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Document", "FullName", "ModifiedAt" },
                values: new object[,]
                {
                    { 43, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(7283), "704.419.995-06", "Warley Reis", null },
                    { 44, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(7831), "579.618.783-00", "Davi Moreira", null },
                    { 45, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(8434), "492.668.640-64", "Júlio César Albuquerque", null },
                    { 46, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(8976), "854.127.857-35", "Eduarda Saraiva", null },
                    { 47, new DateTime(2023, 6, 28, 8, 26, 32, 527, DateTimeKind.Local).AddTicks(9571), "211.664.623-58", "Raul Braga", null },
                    { 48, new DateTime(2023, 6, 28, 8, 26, 32, 528, DateTimeKind.Local).AddTicks(105), "611.992.281-41", "Sirineu Batista", null },
                    { 49, new DateTime(2023, 6, 28, 8, 26, 32, 528, DateTimeKind.Local).AddTicks(627), "448.052.545-99", "Liz Saraiva", null },
                    { 50, new DateTime(2023, 6, 28, 8, 26, 32, 528, DateTimeKind.Local).AddTicks(1197), "712.420.218-33", "Ana Luiza Barros", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "Description", "ModifiedAt", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5128), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Prático Madeira Bicicleta", 56.625165376139854m, 23 },
                    { 2, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5459), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Genérico Concreto Bicicleta", 88.437053101475341m, 43 },
                    { 3, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5492), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, "Fantástico Concreto Sapatos", 93.125435412726298m, 20 },
                    { 4, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5519), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Genérico Congelado Frango", 94.875986048452003m, 92 },
                    { 5, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5548), null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Licenciado Plástico Chapéu", 75.628417867063093m, 29 },
                    { 6, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5568), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, "Fantástico Aço Carro", 11.92574065245058m, 91 },
                    { 7, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5591), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Genérico Congelado Sabonete", 65.181324711842371m, 65 },
                    { 8, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5611), null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Licenciado Macio Pizza", 1.11478377494954458m, 78 },
                    { 9, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5659), null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Inteligente Madeira Luvas", 52.212469633555186m, 87 },
                    { 10, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5679), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Licenciado Macio Calças", 57.209320283680432m, 67 },
                    { 11, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5697), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Sem marca Borracha Camiseta", 23.30702447240674m, 16 },
                    { 12, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5717), null, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, "Impressionante Plástico Camiseta", 62.361556477211485m, 97 },
                    { 13, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5735), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, "Genérico Granito Computador", 51.48897428624896m, 60 },
                    { 14, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5755), null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Lustroso Madeira Cadeira", 23.43977665565482m, 3 },
                    { 15, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5774), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Refinado Congelado Frango", 51.131205546650173m, 65 },
                    { 16, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5793), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Lindo Metal Peixe", 52.422762173321539m, 9 },
                    { 17, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5812), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Impressionante Algodão Luvas", 69.615769079063998m, 81 },
                    { 18, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5853), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Rústico Macio Chapéu", 81.46519731748234m, 88 },
                    { 19, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5872), null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Licenciado Granito Chapéu", 32.69119689635185m, 17 },
                    { 20, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5890), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Pequeno Aço Sabonete", 39.324312213561649m, 30 },
                    { 21, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5908), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, "Refinado Metal Salada", 37.407141829838197m, 12 },
                    { 22, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5926), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Gostoso Congelado Camiseta", 27.41720885567038m, 34 },
                    { 23, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5947), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, "Inteligente Aço Peixe", 29.788331760341164m, 93 },
                    { 24, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5963), null, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, "Refinado Algodão Bola", 49.190836371165037m, 9 },
                    { 25, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5980), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Prático Borracha Mouse", 68.069001503595124m, 56 },
                    { 26, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(5997), null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Pequeno Madeira Chapéu", 46.094158297615834m, 0 },
                    { 27, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6014), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Pequeno Congelado Sabonete", 48.438529601862916m, 56 },
                    { 28, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6071), null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Incrível Metal Teclado", 95.184875937650212m, 54 },
                    { 29, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6088), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Feito à mão Congelado Salsicha", 89.377528785165631m, 18 },
                    { 30, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6106), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Prático Aço Peixe", 93.660737336789644m, 61 },
                    { 31, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6124), null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Pequeno Granito Salgadinhos", 87.943321625122072m, 32 },
                    { 32, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6141), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, "Inteligente Metal Teclado", 66.534765376668841m, 96 },
                    { 33, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6158), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Incrível Concreto Salada", 75.70760084144335m, 45 },
                    { 34, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6176), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Inteligente Madeira Bola", 16.168488399330013m, 32 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "Description", "ModifiedAt", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 35, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6192), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, "Genérico Granito Atum", 50.437626124283353m, 42 },
                    { 36, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6209), null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, "Feito à mão Fresco Queijo", 74.415714959333197m, 78 },
                    { 37, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6252), null, "The Football Is Good For Training And Recreational Purposes", null, "Incrível Madeira Queijo", 26.375699030856328m, 67 },
                    { 38, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6270), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Ergonômico Macio Calças", 57.903818557025638m, 3 },
                    { 39, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6289), null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, "Ergonômico Macio Calças", 20.721460048272928m, 31 },
                    { 40, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6306), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Licenciado Madeira Atum", 47.189998675381429m, 93 },
                    { 41, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6323), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Rústico Congelado Salada", 95.073605614451584m, 45 },
                    { 42, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6340), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Refinado Borracha Calças", 94.37015862387235m, 9 },
                    { 43, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6357), null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Fantástico Congelado Calças", 46.412714686910032m, 20 },
                    { 44, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6373), null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Rústico Borracha Peixe", 5.0582548073511532m, 44 },
                    { 45, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6389), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Impressionante Metal Camiseta", 45.9236989648018m, 37 },
                    { 46, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6431), null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Licenciado Borracha Bacon", 96.172758145427644m, 33 },
                    { 47, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6450), null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Fantástico Granito Frango", 14.302767065768092m, 55 },
                    { 48, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6467), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Lustroso Madeira Salsicha", 14.242806095055922m, 5 },
                    { 49, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6482), null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Pequeno Concreto Peixe", 37.996726745447623m, 40 },
                    { 50, new DateTime(2023, 6, 28, 8, 26, 32, 529, DateTimeKind.Local).AddTicks(6499), null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Incrível Fresco Peixe", 60.29193128533939m, 40 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "ModifiedAt", "ProductId", "ProductPriceAtMoment", "ProductQuantity", "SaleNumber", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(565), 12, null, 17, 6.319214153827812m, 17, "20230628082632", 107.426640615072804m },
                    { 2, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(966), 9, null, 11, 6.524955823054124m, 12, "20230628082632", 78.299469876649488m },
                    { 3, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(990), 19, null, 18, 2.0276981201142754m, 1, "20230628082632", 2.0276981201142754m },
                    { 4, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1008), 3, null, 4, 12.882626031228084m, 1, "20230628082632", 12.882626031228084m },
                    { 5, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1024), 15, null, 13, 12.779587653692554m, 17, "20230628082632", 217.252990112773418m },
                    { 6, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1038), 6, null, 8, 11.06210690704253m, 14, "20230628082632", 154.86949669859542m },
                    { 7, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1080), 1, null, 3, 8.903861959995476m, 11, "20230628082632", 97.942481559950236m },
                    { 8, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1094), 15, null, 7, 11.668245089998831m, 14, "20230628082632", 163.355431259983634m },
                    { 9, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1109), 16, null, 6, 11.774414459876806m, 2, "20230628082632", 23.548828919753612m },
                    { 10, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1123), 17, null, 20, 19.993739926834544m, 10, "20230628082632", 199.937399268345440m },
                    { 11, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1137), 11, null, 12, 13.327332533056475m, 4, "20230628082632", 53.309330132225900m },
                    { 12, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1150), 18, null, 9, 1.246358770140798m, 4, "20230628082632", 4.985435080563192m },
                    { 13, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1165), 19, null, 20, 6.347453171791652m, 5, "20230628082632", 31.737265858958260m },
                    { 14, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1179), 20, null, 19, 15.844329574726525m, 20, "20230628082632", 316.886591494530500m },
                    { 15, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1192), 4, null, 15, 8.180982983798196m, 15, "20230628082632", 122.714744756972940m },
                    { 16, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1205), 3, null, 18, 6.94714617513637m, 14, "20230628082632", 97.26004645190918m },
                    { 17, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1242), 11, null, 2, 13.702954135404289m, 9, "20230628082632", 123.326587218638601m },
                    { 18, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1256), 7, null, 12, 2.754736820309544m, 4, "20230628082632", 11.018947281238176m },
                    { 19, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1269), 4, null, 16, 14.221855403058003m, 3, "20230628082632", 42.665566209174009m },
                    { 20, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1285), 16, null, 14, 5.64059496428849m, 1, "20230628082632", 5.64059496428849m },
                    { 21, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1300), 8, null, 10, 8.084138681488701m, 2, "20230628082632", 16.168277362977402m },
                    { 22, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1313), 9, null, 10, 15.335955977919283m, 11, "20230628082632", 168.695515757112113m },
                    { 23, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1327), 10, null, 10, 6.723023209412067m, 6, "20230628082632", 40.338139256472402m },
                    { 24, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1340), 14, null, 4, 12.965337386399724m, 8, "20230628082632", 103.722699091197792m },
                    { 25, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1355), 11, null, 10, 4.623601145768681m, 9, "20230628082632", 41.612410311918129m },
                    { 26, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1369), 5, null, 1, 14.856928531926261m, 18, "20230628082632", 267.424713574672698m },
                    { 27, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1404), 13, null, 16, 7.185153129750152m, 7, "20230628082632", 50.296071908251064m },
                    { 28, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1420), 15, null, 4, 10.539038182570423m, 6, "20230628082632", 63.234229095422538m },
                    { 29, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1433), 8, null, 17, 13.823760084964404m, 7, "20230628082632", 96.766320594750828m },
                    { 30, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1446), 2, null, 11, 3.591574529799584m, 3, "20230628082632", 10.774723589398752m },
                    { 31, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1459), 7, null, 19, 2.3680407977300652m, 6, "20230628082632", 14.2082447863803912m },
                    { 32, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1472), 13, null, 18, 17.624991293475511m, 11, "20230628082632", 193.874904228230621m },
                    { 33, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1485), 7, null, 20, 15.405372557657609m, 5, "20230628082632", 77.026862788288045m },
                    { 34, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1497), 14, null, 19, 16.44666311777464m, 8, "20230628082632", 131.57330494219712m },
                    { 35, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1509), 19, null, 3, 6.166115664426405m, 2, "20230628082632", 12.332231328852810m },
                    { 36, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1522), 15, null, 13, 17.596785546625459m, 2, "20230628082632", 35.193571093250918m },
                    { 37, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1534), 8, null, 16, 11.885759803764651m, 1, "20230628082632", 11.885759803764651m },
                    { 38, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1570), 12, null, 18, 4.295114453816597m, 20, "20230628082632", 85.902289076331940m },
                    { 39, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1583), 17, null, 20, 11.80308084645329m, 16, "20230628082632", 188.84929354325264m },
                    { 40, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1596), 12, null, 14, 2.3196042790693959m, 10, "20230628082632", 23.1960427906939590m },
                    { 41, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1608), 7, null, 11, 12.159183331515941m, 9, "20230628082632", 109.432649983643469m },
                    { 42, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1620), 17, null, 4, 7.166430621313869m, 16, "20230628082632", 114.662889941021904m }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "ModifiedAt", "ProductId", "ProductPriceAtMoment", "ProductQuantity", "SaleNumber", "Total" },
                values: new object[,]
                {
                    { 43, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1632), 6, null, 10, 11.931447153874432m, 7, "20230628082632", 83.520130077121024m },
                    { 44, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1645), 10, null, 19, 6.162229219187121m, 11, "20230628082632", 67.784521411058331m },
                    { 45, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1657), 13, null, 5, 2.7072312922746927m, 19, "20230628082632", 51.4373945532191613m },
                    { 46, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1670), 12, null, 16, 12.023828367263264m, 6, "20230628082632", 72.142970203579584m },
                    { 47, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1683), 16, null, 3, 15.249849954103564m, 14, "20230628082632", 213.497899357449896m },
                    { 48, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1719), 11, null, 10, 10.300325672378646m, 16, "20230628082632", 164.805210758058336m },
                    { 49, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1733), 7, null, 17, 5.460148371093667m, 13, "20230628082632", 70.981928824217671m },
                    { 50, new DateTime(2023, 6, 28, 8, 26, 32, 531, DateTimeKind.Local).AddTicks(1746), 4, null, 4, 10.223994438536119m, 14, "20230628082632", 143.135922139505666m }
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
