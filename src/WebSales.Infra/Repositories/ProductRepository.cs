using Microsoft.EntityFrameworkCore;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;
using WebSales.Infra.Data;

namespace WebSales.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) => _context = context;

        public async Task<int> AddAsync(Product entity)
        {
            //bool result;
            //try
            //{
            //    await _context.Products.AddAsync(entity).Result;
            //    await _context.SaveChangesAsync();
            //}
            //catch(Exception)
            //{
            //    throw;
            //}
            throw new NotImplementedException();
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            try
            {
                Product product = await _context.Products
                    .AsNoTracking()
                    .FirstOrDefaultAsync(p => p.Id == id);
                return product;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Product>> GetProductsPurchasedByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Product entity)
        {
            try
            {
                _context.Products.Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                _context.Remove(new { Id = id });
                await _context.SaveChangesAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
