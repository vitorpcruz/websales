using WebSales.Domain.ValueObjects;

namespace WebSales.Infra.Interfaces
{
    public interface IValueObjectsRepository
    {
        Task<IEnumerable<ProductSold>> ProductsPurchasedByCustomerAsync(int id);
        Task<IEnumerable<BestSellingProduct>> BestSeillingProductsAsync();
        Task<IEnumerable<PurchaseByValidCustomer>> PurchasesMadebyValidCustomers();
        Task<IEnumerable<SaleComplete>> GetAllSalesByDateAsync(DateTime date);
        Task<SaleCustomerProduct> GetCustomersAndProductsForSale();
    }
}
 