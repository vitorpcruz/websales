﻿using Microsoft.EntityFrameworkCore;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;
using WebSales.Infra.Data;
using WebSales.Domain.ValueObjects;

namespace WebSales.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) => _context = context;

        public async Task AddAsync(Product entity)
        {
            try
            {
                await _context.Products.AddAsync(entity);
                var result = await _context.SaveChangesAsync();
            }
            catch(Exception)
            {
                throw;
            }
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
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task RemoveAsync(Product product)
        {
            try
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Product>> ProductsPurchasedByCustomerAsync(int id)
        {
            var query = from p in _context.Products
                        join s in _context.Sales on p.Id equals s.ProductId
                        join c in _context.Customers on s.CustomerId equals c.Id
                        where c.Id == id
                        select new Product(p.Name, p.Description, p.Price, p.Quantity)                        ;
            return await query.ToListAsync();
        }
    }
}
