using WebSales.Domain.Entities;
using WebSales.Services.DTOs;

namespace WebSales.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductDTO> FindProductByIdAsync(int id);
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task AddProductAsync(ProductDTO productDto);
        Task UpdateProductAsync(ProductDTO productDto);
        Task DeleteProductAsync(int id);
        Task<IEnumerable<ProductDTO>> ProductsPurchasedByCustomerAsync(int id);
    }
}
