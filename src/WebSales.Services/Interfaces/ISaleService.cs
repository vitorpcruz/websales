using WebSales.Domain.ValueObjects;

namespace WebSales.Services.Interfaces
{
    public interface ISaleService
    {
        Task<decimal> GetTodayProfitAsync();
    }
}
