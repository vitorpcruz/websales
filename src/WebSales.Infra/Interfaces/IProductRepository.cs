using WebSales.Domain.Entities;

namespace WebSales.Infra.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsPurchasedByIdAsync(int id);
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}
