using WebSales.Domain.ValueObjects;
using WebSales.Services.DTOs;

namespace WebSales.Services.Interfaces
{
    public interface ISaleService
    {
        Task<decimal> GetTodayProfitAsync();
        Task RegisterSalesAsync(SaleDTO saleDto);
    }
}
