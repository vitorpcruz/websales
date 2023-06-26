using Microsoft.EntityFrameworkCore;
using WebSales.Infra.Interfaces;
using WebSales.Infra.Data;
using WebSales.Domain.ValueObjects;

namespace WebSales.Infra.Repositories
{
    public class ProductSoldRepository : IProductSoldRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductSoldRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<ProductSold>> GetProductsSoldByDate(DateTime date)
        {
            var query = from p in _context.Products
                        join s in _context.Sales
                        on p.Id equals s.Id
                        where s.ToString().Contains(date.ToString("yyyy-MM-dd"))
                        orderby p.Id
                        select new ProductSold(
                            p.Id,
                            p.Name,
                            s.SaleNumber,
                            s.ProductPriceAtMoment,
                            s.ProductQuantity,
                            s.Total,
                            s.SaleCancelled,
                            s.CreatedAt,
                            s.ModifiedAt
                        );

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<ICollection<ProductSold>> GetProductsNotSoldByDate(DateTime date)
        {
            var query = from p in _context.Products
                        join s in _context.Sales on p.Id equals s.ProductId into _x
                        from x in _x.DefaultIfEmpty()
                        where x.CreatedAt.ToString().Contains(date.ToString("yyyy-MM-dd"))
                        orderby p.Id
                        select new ProductSold(
                            p.Id,
                            p.Name,
                            x.SaleNumber,
                            x.ProductPriceAtMoment,
                            x.ProductQuantity,
                            x.Total,
                            x.SaleCancelled,
                            x.CreatedAt,
                            x.ModifiedAt
                        );

            return await query.AsNoTracking().ToListAsync();
        }
    }
}
