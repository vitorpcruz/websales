using Microsoft.EntityFrameworkCore;
using WebSales.Domain.Entities;

namespace WebSales.Infra.Contexts
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public Context(DbContextOptions<Context> options) : base(options) {  }
    }
}