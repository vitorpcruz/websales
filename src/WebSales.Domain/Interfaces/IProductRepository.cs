using WebSales.Domain.Entities;

namespace WebSales.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsPurchasedByIdAsync(int id);
    }
}
