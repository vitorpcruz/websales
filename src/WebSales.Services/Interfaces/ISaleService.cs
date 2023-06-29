using WebSales.Services.DTOs;

namespace WebSales.Services.Interfaces
{
    public interface ISaleService
    {
        Task<decimal> GetTodayProfitAsync();
        Task RegisterSalesAsync(SaleDTO saleDto);
        Task<SaleDTO> GetSaleBySaleNumber(string saleNumber);
        Task CancelSaleBySaleNumberAsync(string saleNumber);
        Task RevertCancelledSaleBySaleNumberAsync(string saleNumber);
        Task DeleteSaleAsync(int id);
    }
}
