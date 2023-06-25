using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSales.Infra.Migrations
{
    public partial class addCustomerDataMock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Document", "FullName", "ModifiedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 9, 12, 16, 748, DateTimeKind.Local).AddTicks(6256), "282.502.923-83", "Bruna Moraes", null },
                    { 2, new DateTime(2023, 6, 25, 9, 12, 16, 748, DateTimeKind.Local).AddTicks(7734), "262.528.966-08", "Tertuliano Albuquerque", null },
                    { 3, new DateTime(2023, 6, 25, 9, 12, 16, 748, DateTimeKind.Local).AddTicks(8484), "495.867.274-59", "Maria Cecília Santos", null },
                    { 4, new DateTime(2023, 6, 25, 9, 12, 16, 748, DateTimeKind.Local).AddTicks(9247), "589.847.480-30", "Lara Franco", null },
                    { 5, new DateTime(2023, 6, 25, 9, 12, 16, 748, DateTimeKind.Local).AddTicks(9982), "112.460.099-00", "Lucca Carvalho", null },
                    { 6, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(662), "878.186.920-70", "Esther Oliveira", null },
                    { 7, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(1360), "027.817.606-25", "Lucca Martins", null },
                    { 8, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(1949), "983.633.042-98", "Lavínia Saraiva", null },
                    { 9, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(2633), "459.977.356-56", "Caio Souza", null },
                    { 10, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(3236), "899.166.005-38", "Alice Albuquerque", null },
                    { 11, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(3889), "947.922.857-20", "Isabella Pereira", null },
                    { 12, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(4519), "719.988.073-12", "Vitória Braga", null },
                    { 13, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(5104), "536.160.620-04", "Leonardo Batista", null },
                    { 14, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(5723), "179.240.155-82", "João Miguel Costa", null },
                    { 15, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(6325), "750.220.650-70", "Norberto Silva", null },
                    { 16, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(6946), "723.222.904-67", "Giovanna Albuquerque", null },
                    { 17, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(7511), "431.814.675-88", "Lucca Barros", null },
                    { 18, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(8126), "172.106.031-66", "Núbia Batista", null },
                    { 19, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(8735), "751.709.501-36", "Elisa Franco", null },
                    { 20, new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(9414), "111.286.938-79", "Maria Helena Nogueira", null },
                    { 21, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(3), "357.552.965-53", "Clara Nogueira", null },
                    { 22, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(646), "127.584.013-20", "Enzo Gabriel Barros", null },
                    { 23, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(1220), "951.540.371-54", "Meire Macedo", null },
                    { 24, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(1834), "811.276.888-98", "Roberta Pereira", null },
                    { 25, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(2467), "325.222.489-52", "Silas Melo", null },
                    { 26, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(3030), "431.003.606-64", "Ana Clara Carvalho", null },
                    { 27, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(3609), "510.551.272-32", "Morgana Souza", null },
                    { 28, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(4246), "269.781.353-56", "Luiza Melo", null },
                    { 29, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(4806), "957.685.976-03", "Felícia Oliveira", null },
                    { 30, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(5442), "700.898.366-26", "Bryan Pereira", null },
                    { 31, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(6025), "275.859.617-23", "Júlio César Souza", null },
                    { 32, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(6616), "492.978.028-42", "Gabriel Moreira", null },
                    { 33, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(7179), "937.219.318-66", "Cecília Pereira", null },
                    { 34, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(7743), "440.030.666-69", "Natália Braga", null },
                    { 35, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(8400), "755.395.317-28", "Suélen Albuquerque", null },
                    { 36, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(8933), "057.652.408-52", "Beatriz Melo", null },
                    { 37, new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(9767), "649.989.072-39", "Lorenzo Santos", null },
                    { 38, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(458), "871.801.114-49", "Valentina Carvalho", null },
                    { 39, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(1050), "140.279.309-08", "Maria Helena Souza", null },
                    { 40, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(1672), "207.011.131-89", "Noah Macedo", null },
                    { 41, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(2243), "466.716.060-80", "Antônio Braga", null },
                    { 42, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(3003), "470.147.392-80", "Pedro Henrique Xavier", null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Document", "FullName", "ModifiedAt" },
                values: new object[,]
                {
                    { 43, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(3639), "538.407.366-76", "Lucas Melo", null },
                    { 44, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(4342), "752.161.147-00", "Heloísa Silva", null },
                    { 45, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(4960), "912.823.965-28", "Valentina Xavier", null },
                    { 46, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(5537), "758.099.876-99", "Deneval Martins", null },
                    { 47, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(6188), "102.403.931-55", "Isabella Macedo", null },
                    { 48, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(6799), "595.296.485-02", "Natália Pereira", null },
                    { 49, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(7404), "754.713.135-26", "Helena Melo", null },
                    { 50, new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(8035), "747.732.426-20", "João Lucas Moraes", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
