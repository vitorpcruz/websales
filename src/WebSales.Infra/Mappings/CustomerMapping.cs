using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSales.Domain.Entities;

namespace WebSales.Infra.Mappings
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.FullName)
                .HasMaxLength(150)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(x => x.Document)
                .HasMaxLength(14)
                .HasColumnType("char")
                .IsRequired();

            builder.Property(x => x.IsLegalPerson)
                .HasDefaultValue(false)
                .HasColumnType("bit")
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.ModifiedAt);

            builder.HasIndex(x => x.Document)
                .IsUnique();
        }
    }
}
