﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSales.Infra.Data;

#nullable disable

namespace WebSales.Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230629014822_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebSales.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("varchar(18)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("IsLegalPerson")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Document")
                        .IsUnique();

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(5430),
                            Document = "382.152.203-80",
                            FullName = "Isabela Saraiva",
                            IsLegalPerson = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(6894),
                            Document = "852.628.770-28",
                            FullName = "Matheus Oliveira",
                            IsLegalPerson = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(7618),
                            Document = "942.456.367-18",
                            FullName = "Félix Albuquerque",
                            IsLegalPerson = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(8305),
                            Document = "070.495.427-33",
                            FullName = "Víctor Pereira",
                            IsLegalPerson = false
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(8918),
                            Document = "883.604.630-42",
                            FullName = "Hélio Macedo",
                            IsLegalPerson = false
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 242, DateTimeKind.Local).AddTicks(9526),
                            Document = "031.553.809-00",
                            FullName = "Margarida Melo",
                            IsLegalPerson = false
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 243, DateTimeKind.Local).AddTicks(128),
                            Document = "697.970.771-01",
                            FullName = "João Miguel Braga",
                            IsLegalPerson = false
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 243, DateTimeKind.Local).AddTicks(757),
                            Document = "213.674.466-60",
                            FullName = "Yago Santos",
                            IsLegalPerson = false
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 243, DateTimeKind.Local).AddTicks(1369),
                            Document = "992.035.824-01",
                            FullName = "Marli Franco",
                            IsLegalPerson = false
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 243, DateTimeKind.Local).AddTicks(1944),
                            Document = "430.282.699-10",
                            FullName = "Célia Moreira",
                            IsLegalPerson = false
                        });
                });

            modelBuilder.Entity("WebSales.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(4954),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Genérico Borracha Toalhas",
                            Price = 11.365512587310034m,
                            Quantity = 45
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5258),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Sem marca Aço Calças",
                            Price = 44.227627758033895m,
                            Quantity = 91
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5293),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Name = "Licenciado Plástico Bola",
                            Price = 32.776356910107304m,
                            Quantity = 82
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5317),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Rústico Fresco Pizza",
                            Price = 70.388869774976092m,
                            Quantity = 55
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5342),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Feito à mão Fresco Toalhas",
                            Price = 50.146406511197644m,
                            Quantity = 97
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5391),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Name = "Lustroso Aço Calças",
                            Price = 42.049319724685558m,
                            Quantity = 31
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5412),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Name = "Feito à mão Fresco Bicicleta",
                            Price = 71.075760385589695m,
                            Quantity = 69
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5429),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Rústico Macio Camiseta",
                            Price = 87.223846591226476m,
                            Quantity = 30
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5448),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Prático Macio Mouse",
                            Price = 89.196131279344429m,
                            Quantity = 36
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2023, 6, 28, 22, 48, 22, 244, DateTimeKind.Local).AddTicks(5465),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Impressionante Madeira Salgadinhos",
                            Price = 76.021604075099836m,
                            Quantity = 29
                        });
                });

            modelBuilder.Entity("WebSales.Domain.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductPriceAtMoment")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<bool>("SaleCancelled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("SaleNumber")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("char(14)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("WebSales.Domain.Entities.Product", b =>
                {
                    b.HasOne("WebSales.Domain.Entities.Customer", null)
                        .WithMany("ProductsPurchased")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("WebSales.Domain.Entities.Sale", b =>
                {
                    b.HasOne("WebSales.Domain.Entities.Customer", "Customer")
                        .WithMany("CustomerSales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("WebSales.Domain.Entities.Product", "Product")
                        .WithMany("ProductsSold")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebSales.Domain.Entities.Customer", b =>
                {
                    b.Navigation("CustomerSales");

                    b.Navigation("ProductsPurchased");
                });

            modelBuilder.Entity("WebSales.Domain.Entities.Product", b =>
                {
                    b.Navigation("ProductsSold");
                });
#pragma warning restore 612, 618
        }
    }
}
