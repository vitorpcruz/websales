using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSales.Domain.Entities;
using WebSales.Infra.Mocks;

namespace WebSales.Infra.Mappings
{
    public class SaleMapping : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.SaleNumber)
                .HasMaxLength(14)
                .HasColumnType("char")
                .IsRequired();

            builder.Property(x => x.Total)
                .HasColumnType("numeric(10,2)")
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.ModifiedAt);

            builder.HasOne(x => x.Customer)
                .WithMany(y => y.CustomerSales)
                .HasForeignKey(x => x.CustomerId);

            builder.HasOne(x => x.Product)
                .WithMany(y => y.ProductsSold)
                .HasForeignKey(x => x.ProductId);

            builder.HasData(SaleMock.GenerateSaleMock());
        }
    }
}
