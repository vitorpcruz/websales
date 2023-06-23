using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;
using WebSales.Infra.Contexts;

namespace WebSales.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context) => _context = context;

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

    public class CustomerRepository : ICustomerRepository
    {
        private readonly string _connectionString;

        public CustomerRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("WebSalesDb");
        }

        public async Task<Customer> AddAsync(Customer entity)
        {
            string query = "INSERT INTO customers (full_name, document, is_legal_person) VALUES (@full_name, @document, @is_legal_person)";

            using (SqlConnection connection = new(_connectionString))
            {
                try
                {
                    SqlCommand command = new(query, connection);

                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@full_name", entity.FullName);
                    command.Parameters.AddWithValue("@document", entity.Document);
                    command.Parameters.AddWithValue("@is_legal_person", entity.IsLegalPerson);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if(connection?.State == ConnectionState.Open)
                    {
                        await connection.CloseAsync();
                    }
                }
            }

            return entity;
        }

        public Task<Customer> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

    }
}
