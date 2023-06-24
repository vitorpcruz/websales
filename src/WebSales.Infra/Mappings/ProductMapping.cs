using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSales.Domain.Entities;

namespace WebSales.Infra.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("varchar")
                .HasMaxLength(1000);

            builder.Property(x => x.Price)
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Property(x => x.Quantity)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.ModifiedAt);
        }
    }
}
