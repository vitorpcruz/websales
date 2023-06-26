using WebSales.Domain.ValueObjects;

namespace WebSales.Infra.Interfaces
{
    public interface IProductSoldRepository
    {
        Task<ICollection<ProductSold>> GetProductsSoldByDate(DateTime date);
        Task<ICollection<ProductSold>> GetProductsNotSoldByDate(DateTime date);
    }
}
