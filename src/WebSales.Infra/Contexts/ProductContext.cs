using Microsoft.EntityFrameworkCore;
using WebSales.Domain.Entities;

namespace WebSales.Infra.Contexts
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options) {  }
    }
}