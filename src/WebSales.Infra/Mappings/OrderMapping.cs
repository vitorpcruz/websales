using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSales.Domain.Entities;

namespace WebSales.Infra.Mappings
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.OrderNumber)
                .HasMaxLength(14)
                .HasColumnType("char")
                .IsRequired();

            builder.Property(x => x.Total)
                .HasColumnType("numeric(10,2)")
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.ModifiedAt);

            builder.HasOne(x => x.Customer).WithMany(y => y.RegisterOrders).HasForeignKey(x => x.CustomerId);

            builder.HasOne(x => x.Product)
                .WithMany(y => y.Orders)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
