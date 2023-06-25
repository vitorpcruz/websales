﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSales.Infra.Data;

#nullable disable

namespace WebSales.Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebSales.Domain.Entities.Customer", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("char(14)");

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
                });

            modelBuilder.Entity("WebSales.Domain.Entities.Product", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

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

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebSales.Domain.Entities.Sale", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SaleNumber")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("char(14)");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Sales");
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
                });

            modelBuilder.Entity("WebSales.Domain.Entities.Product", b =>
                {
                    b.Navigation("ProductsSold");
                });
#pragma warning restore 612, 618
        }
    }
}
