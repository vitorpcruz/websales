using Microsoft.EntityFrameworkCore;
using WebSales.Domain.Entities;
using WebSales.Domain.Interfaces;
using WebSales.Infra.Contexts;

namespace WebSales.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context) => _context = context;

        public async Task<Product> AddAsync(Product entity)
        {
            await _context.Products.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            Product product = await _context.Products
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetProductsPurchasedByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            _context.Products.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task RemoveAsync(int id)
        {
            _context.Remove(new { Id = id });
            await _context.SaveChangesAsync();
        }
    }
}
