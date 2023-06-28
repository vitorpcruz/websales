using WebSales.Domain.ValueObjects;
using WebSales.Services.DTOs;

namespace WebSales.Services.Interfaces
{
    public interface IValueObjectService
    {
        Task<IEnumerable<ProductSoldDTO>> ProductsPurchasedByCustomerAsync(int id);
        Task<IEnumerable<SaleCompleteDTO>> GetAllSalesByDateAsync(DateTime date);
        Task<IEnumerable<BestSellingProductDTO>> BestSeillingProductsAsync();
        Task<IEnumerable<PurchaseByValidCustomerDTO>> PurchasesMadebyValidCustomers();
        Task<SaleCustomerProductDTO> GetCustomersAndProductsForSale();
    }
}