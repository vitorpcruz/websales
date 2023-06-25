using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSales.Infra.Migrations
{
    public partial class addMocskData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 814, DateTimeKind.Local).AddTicks(3391), "616.664.527-93", "Paula Macedo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 814, DateTimeKind.Local).AddTicks(4836), "952.404.526-52", "Lucca Batista" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 814, DateTimeKind.Local).AddTicks(5644), "759.943.442-90", "Yago Batista" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 814, DateTimeKind.Local).AddTicks(6361), "576.635.825-35", "Giovanna Franco" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 814, DateTimeKind.Local).AddTicks(7066), "906.515.194-03", "Antonella Pereira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 814, DateTimeKind.Local).AddTicks(7760), "935.021.629-99", "Melissa Barros" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 814, DateTimeKind.Local).AddTicks(8455), "584.826.358-24", "Yasmin Santos" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 814, DateTimeKind.Local).AddTicks(9106), "565.670.080-16", "Carlos Moreira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 814, DateTimeKind.Local).AddTicks(9809), "151.473.824-45", "Maria Luiza Pereira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(450), "278.770.962-16", "Arthur Martins" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(1134), "846.477.364-15", "Sophia Carvalho" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(1833), "041.266.600-62", "Salvador Silva" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(2466), "474.529.844-71", "Davi Lucca Carvalho" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(3081), "813.396.741-49", "Washington Albuquerque" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(3764), "180.101.465-52", "Fábio Martins" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(4462), "463.288.701-32", "Carla Saraiva" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(5158), "463.987.908-39", "Heloísa Silva" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(5813), "915.961.484-62", "Karla Albuquerque" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(6484), "509.160.555-07", "Suélen Macedo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(7113), "859.581.703-09", "Pietro Barros" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(7814), "679.142.444-30", "Beatriz Oliveira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(8478), "159.737.551-93", "Leonardo Franco" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(9109), "993.651.455-62", "Félix Nogueira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 815, DateTimeKind.Local).AddTicks(9793), "365.996.772-66", "Vicente Melo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(405), "111.738.855-79", "Yasmin Albuquerque" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(1008), "294.235.662-60", "Maria Clara Carvalho" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(1680), "253.910.026-05", "Bryan Costa" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(2312), "803.730.112-53", "Víctor Saraiva" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(2961), "459.207.959-05", "Isabelly Xavier" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(3583), "973.218.359-44", "Carlos Albuquerque" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(4248), "406.702.882-25", "Frederico Barros" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(4862), "796.945.676-61", "Hélio Moraes" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(5469), "308.640.360-86", "Nicolas Souza" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(6138), "608.691.842-29", "Manuela Carvalho" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(6835), "438.938.151-20", "Mariana Saraiva" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(7456), "514.745.427-60", "Roberto Martins" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(8085), "646.315.599-34", "Guilherme Saraiva" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(8740), "877.595.211-46", "Felipe Costa" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 816, DateTimeKind.Local).AddTicks(9379), "976.722.372-09", "Víctor Souza" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 817, DateTimeKind.Local).AddTicks(36), "729.001.435-94", "Hélio Franco" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 817, DateTimeKind.Local).AddTicks(633), "594.202.031-07", "Laura Reis" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 817, DateTimeKind.Local).AddTicks(1304), "279.266.121-62", "Aline Souza" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 817, DateTimeKind.Local).AddTicks(1900), "284.267.403-08", "Sílvia Costa" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 817, DateTimeKind.Local).AddTicks(2563), "980.255.311-55", "Melissa Melo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 817, DateTimeKind.Local).AddTicks(3177), "128.491.869-61", "Melissa Moreira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 817, DateTimeKind.Local).AddTicks(3834), "678.196.579-44", "Bernardo Costa" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 817, DateTimeKind.Local).AddTicks(4482), "666.123.840-26", "Marcos Martins" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 817, DateTimeKind.Local).AddTicks(5106), "872.000.494-09", "Ígor Xavier" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 817, DateTimeKind.Local).AddTicks(5757), "471.700.013-73", "Vicente Braga" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 21, 35, 817, DateTimeKind.Local).AddTicks(6442), "459.623.945-26", "Felícia Melo" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "ModifiedAt", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2267), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, "Fantástico Plástico Queijo", 3.2260601133187m, 44 },
                    { 2, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2617), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Genérico Congelado Carro", 49.4264150699372m, 74 },
                    { 3, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2702), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, "Inteligente Algodão Bacon", 64.921245295969m, 11 },
                    { 4, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2730), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Ergonômico Algodão Chapéu", 80.617138762519m, 64 },
                    { 5, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2752), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, "Sem marca Borracha Teclado", 83.6093871814624m, 39 },
                    { 6, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2773), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Lindo Concreto Carro", 94.6202007443819m, 5 },
                    { 7, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2794), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Genérico Metal Atum", 8.40349445237811m, 95 },
                    { 8, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2816), "The Football Is Good For Training And Recreational Purposes", null, "Lustroso Borracha Queijo", 74.7672691419891m, 63 },
                    { 9, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2835), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Lindo Congelado Bola", 43.1596555563644m, 85 },
                    { 10, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2853), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, "Genérico Madeira Mouse", 4.76860813860034m, 69 },
                    { 11, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2872), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Pequeno Plástico Atum", 21.4444059783886m, 89 },
                    { 12, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2890), "The Football Is Good For Training And Recreational Purposes", null, "Inteligente Congelado Sapatos", 77.1541537823514m, 26 },
                    { 13, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2941), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Lustroso Metal Salsicha", 76.8072403636568m, 62 },
                    { 14, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2961), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Feito à mão Madeira Calças", 20.4543022547691m, 26 },
                    { 15, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(2980), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Lindo Plástico Pizza", 44.9044286417811m, 21 },
                    { 16, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3000), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, "Rústico Aço Carro", 48.3866411034973m, 100 },
                    { 17, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3019), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, "Feito à mão Concreto Bicicleta", 79.9144063072098m, 44 },
                    { 18, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3038), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Incrível Borracha Camiseta", 82.9785707243832m, 72 },
                    { 19, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3057), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Feito à mão Metal Chapéu", 50.7248554493696m, 77 },
                    { 20, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3076), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Sem marca Borracha Computador", 89.6432317952364m, 1 },
                    { 21, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3093), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Incrível Macio Bicicleta", 8.59138467572118m, 56 },
                    { 22, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3139), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Fantástico Granito Mouse", 97.7001138375038m, 69 },
                    { 23, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3160), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Inteligente Borracha Peixe", 40.2639350485322m, 24 },
                    { 24, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3178), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Inteligente Concreto Queijo", 77.9556137121684m, 21 },
                    { 25, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3195), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Fantástico Borracha Carro", 3.12974928624601m, 93 },
                    { 26, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3212), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Incrível Borracha Atum", 18.689293242402m, 74 },
                    { 27, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3228), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, "Licenciado Algodão Mesa", 20.1918166644832m, 14 },
                    { 28, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3247), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Gostoso Madeira Cadeira", 78.4731147634696m, 9 },
                    { 29, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3265), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, "Incrível Macio Frango", 10.9938698560075m, 37 },
                    { 30, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3283), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Lindo Fresco Sabonete", 64.9388819709027m, 33 },
                    { 31, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3301), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, "Prático Aço Salsicha", 64.0428334380816m, 46 },
                    { 32, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3350), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Sem marca Metal Peixe", 86.8052472719766m, 87 },
                    { 33, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3368), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, "Feito à mão Fresco Camiseta", 4.88213602381913m, 42 },
                    { 34, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3385), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Sem marca Aço Sabonete", 12.537422867696m, 92 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "ModifiedAt", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 35, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3402), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Lindo Aço Chapéu", 11.9133554709403m, 24 },
                    { 36, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3420), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Lindo Concreto Frango", 87.8125042731304m, 41 },
                    { 37, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3438), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Ergonômico Borracha Toalhas", 2.91066183938879m, 17 },
                    { 38, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3454), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, "Rústico Plástico Carro", 64.9862249885696m, 63 },
                    { 39, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3471), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Lindo Algodão Sapatos", 20.4501436472683m, 12 },
                    { 40, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3488), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, "Prático Metal Computador", 85.2322955424581m, 66 },
                    { 41, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3535), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Prático Plástico Sabonete", 96.3378731861356m, 74 },
                    { 42, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3552), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Feito à mão Aço Pizza", 35.5288115482279m, 55 },
                    { 43, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3570), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, "Licenciado Macio Sabonete", 92.9092475932598m, 47 },
                    { 44, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3587), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, "Prático Metal Calças", 19.3936510759952m, 63 },
                    { 45, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3604), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, "Feito à mão Algodão Mouse", 51.8409776192202m, 54 },
                    { 46, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3623), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Licenciado Algodão Calças", 37.9418111571118m, 45 },
                    { 47, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3641), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, "Feito à mão Macio Luvas", 22.2751843918901m, 4 },
                    { 48, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3662), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, "Genérico Aço Salgadinhos", 27.4065009642632m, 50 },
                    { 49, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3681), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Genérico Algodão Salgadinhos", 22.9676047501907m, 54 },
                    { 50, new DateTime(2023, 6, 25, 9, 21, 35, 819, DateTimeKind.Local).AddTicks(3728), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, "Rústico Fresco Chapéu", 2.36348039464166m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "ModifiedAt", "ProductId", "Quantity", "SaleNumber", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(8680), 2, null, 9, 4, "20230625092135", 12.0599728219512m },
                    { 2, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9044), 15, null, 11, 16, "20230625092135", 11.0891555657476m },
                    { 3, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9070), 18, null, 11, 4, "20230625092135", 19.39101614775m },
                    { 4, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9087), 4, null, 14, 6, "20230625092135", 16.7870569116519m },
                    { 5, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9102), 7, null, 19, 17, "20230625092135", 11.188731018016m },
                    { 6, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9115), 11, null, 15, 14, "20230625092135", 17.5857005960636m },
                    { 7, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9127), 6, null, 14, 8, "20230625092135", 13.150091710505m },
                    { 8, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9138), 6, null, 17, 20, "20230625092135", 16.5596374972735m },
                    { 9, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9180), 9, null, 10, 15, "20230625092135", 14.7905979779994m },
                    { 10, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9194), 4, null, 12, 7, "20230625092135", 5.57791800335351m },
                    { 11, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9206), 6, null, 20, 1, "20230625092135", 7.64113882112822m },
                    { 12, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9217), 1, null, 5, 14, "20230625092135", 5.65973378930819m },
                    { 13, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9229), 4, null, 16, 20, "20230625092135", 1.61544871727962m },
                    { 14, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9241), 8, null, 9, 2, "20230625092135", 19.4551426107951m },
                    { 15, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9252), 14, null, 5, 20, "20230625092135", 10.4561311994032m },
                    { 16, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9264), 1, null, 16, 20, "20230625092135", 17.9228148317356m },
                    { 17, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9276), 11, null, 17, 1, "20230625092135", 2.21701989344065m },
                    { 18, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9288), 3, null, 5, 19, "20230625092135", 1.96963410403108m },
                    { 19, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9299), 13, null, 3, 11, "20230625092135", 18.0260958883808m },
                    { 20, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9311), 13, null, 8, 1, "20230625092135", 18.8939333879769m },
                    { 21, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9362), 20, null, 6, 1, "20230625092135", 1.17508268132645m },
                    { 22, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9374), 7, null, 6, 12, "20230625092135", 11.0630935313613m },
                    { 23, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9385), 19, null, 16, 11, "20230625092135", 17.0940997408982m },
                    { 24, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9397), 20, null, 2, 13, "20230625092135", 12.0075490237452m },
                    { 25, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9408), 10, null, 11, 11, "20230625092135", 14.5857279930186m },
                    { 26, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9418), 13, null, 20, 14, "20230625092135", 9.73792210747728m },
                    { 27, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9430), 10, null, 20, 18, "20230625092135", 10.1646144334258m },
                    { 28, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9441), 9, null, 2, 20, "20230625092135", 14.8082440228494m },
                    { 29, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9453), 7, null, 16, 14, "20230625092135", 8.33095402018041m },
                    { 30, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9464), 6, null, 1, 1, "20230625092135", 2.30292359318265m },
                    { 31, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9476), 17, null, 8, 19, "20230625092135", 6.87399837973104m },
                    { 32, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9519), 3, null, 18, 3, "20230625092135", 15.5688262046541m },
                    { 33, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9534), 18, null, 8, 4, "20230625092135", 1.33205840180562m },
                    { 34, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9546), 1, null, 9, 18, "20230625092135", 4.39925372706208m },
                    { 35, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9558), 7, null, 11, 12, "20230625092135", 2.77380499156315m },
                    { 36, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9570), 4, null, 20, 14, "20230625092135", 7.2038052955723m },
                    { 37, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9581), 5, null, 8, 17, "20230625092135", 8.01934344228194m },
                    { 38, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9592), 4, null, 5, 8, "20230625092135", 13.7571756784799m },
                    { 39, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9604), 9, null, 1, 12, "20230625092135", 1.37385995959581m },
                    { 40, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9616), 2, null, 2, 15, "20230625092135", 3.8246084557438m },
                    { 41, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9627), 5, null, 6, 1, "20230625092135", 8.14486467562757m },
                    { 42, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9638), 10, null, 5, 16, "20230625092135", 11.0487359988582m }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "ModifiedAt", "ProductId", "Quantity", "SaleNumber", "Total" },
                values: new object[,]
                {
                    { 43, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9648), 6, null, 3, 1, "20230625092135", 7.60569617894687m },
                    { 44, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9689), 8, null, 2, 12, "20230625092135", 10.2426620488511m },
                    { 45, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9701), 13, null, 14, 14, "20230625092135", 11.2251596905829m },
                    { 46, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9711), 18, null, 6, 12, "20230625092135", 9.88786347600797m },
                    { 47, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9722), 19, null, 17, 11, "20230625092135", 12.5204049249346m },
                    { 48, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9733), 13, null, 20, 7, "20230625092135", 17.0247149843113m },
                    { 49, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9744), 2, null, 13, 8, "20230625092135", 3.7760203067003m },
                    { 50, new DateTime(2023, 6, 25, 9, 21, 35, 820, DateTimeKind.Local).AddTicks(9755), 14, null, 6, 2, "20230625092135", 11.2529439470115m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 748, DateTimeKind.Local).AddTicks(6256), "282.502.923-83", "Bruna Moraes" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 748, DateTimeKind.Local).AddTicks(7734), "262.528.966-08", "Tertuliano Albuquerque" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 748, DateTimeKind.Local).AddTicks(8484), "495.867.274-59", "Maria Cecília Santos" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 748, DateTimeKind.Local).AddTicks(9247), "589.847.480-30", "Lara Franco" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 748, DateTimeKind.Local).AddTicks(9982), "112.460.099-00", "Lucca Carvalho" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(662), "878.186.920-70", "Esther Oliveira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(1360), "027.817.606-25", "Lucca Martins" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(1949), "983.633.042-98", "Lavínia Saraiva" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(2633), "459.977.356-56", "Caio Souza" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(3236), "899.166.005-38", "Alice Albuquerque" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(3889), "947.922.857-20", "Isabella Pereira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(4519), "719.988.073-12", "Vitória Braga" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(5104), "536.160.620-04", "Leonardo Batista" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(5723), "179.240.155-82", "João Miguel Costa" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(6325), "750.220.650-70", "Norberto Silva" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(6946), "723.222.904-67", "Giovanna Albuquerque" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(7511), "431.814.675-88", "Lucca Barros" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(8126), "172.106.031-66", "Núbia Batista" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(8735), "751.709.501-36", "Elisa Franco" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 749, DateTimeKind.Local).AddTicks(9414), "111.286.938-79", "Maria Helena Nogueira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(3), "357.552.965-53", "Clara Nogueira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(646), "127.584.013-20", "Enzo Gabriel Barros" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(1220), "951.540.371-54", "Meire Macedo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(1834), "811.276.888-98", "Roberta Pereira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(2467), "325.222.489-52", "Silas Melo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(3030), "431.003.606-64", "Ana Clara Carvalho" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(3609), "510.551.272-32", "Morgana Souza" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(4246), "269.781.353-56", "Luiza Melo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(4806), "957.685.976-03", "Felícia Oliveira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(5442), "700.898.366-26", "Bryan Pereira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(6025), "275.859.617-23", "Júlio César Souza" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(6616), "492.978.028-42", "Gabriel Moreira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(7179), "937.219.318-66", "Cecília Pereira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(7743), "440.030.666-69", "Natália Braga" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(8400), "755.395.317-28", "Suélen Albuquerque" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(8933), "057.652.408-52", "Beatriz Melo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 750, DateTimeKind.Local).AddTicks(9767), "649.989.072-39", "Lorenzo Santos" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(458), "871.801.114-49", "Valentina Carvalho" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(1050), "140.279.309-08", "Maria Helena Souza" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(1672), "207.011.131-89", "Noah Macedo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(2243), "466.716.060-80", "Antônio Braga" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(3003), "470.147.392-80", "Pedro Henrique Xavier" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(3639), "538.407.366-76", "Lucas Melo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(4342), "752.161.147-00", "Heloísa Silva" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(4960), "912.823.965-28", "Valentina Xavier" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(5537), "758.099.876-99", "Deneval Martins" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(6188), "102.403.931-55", "Isabella Macedo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(6799), "595.296.485-02", "Natália Pereira" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(7404), "754.713.135-26", "Helena Melo" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Document", "FullName" },
                values: new object[] { new DateTime(2023, 6, 25, 9, 12, 16, 751, DateTimeKind.Local).AddTicks(8035), "747.732.426-20", "João Lucas Moraes" });
        }
    }
}
