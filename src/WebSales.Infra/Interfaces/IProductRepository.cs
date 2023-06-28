using WebSales.Domain.Entities;

namespace WebSales.Infra.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task RemoveAsync(Product product);
        Task<IEnumerable<Product>> ProductsPurchasedByCustomerAsync(int id);
    }
}
