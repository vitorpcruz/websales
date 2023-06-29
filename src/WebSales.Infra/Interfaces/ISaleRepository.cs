using System.Runtime.CompilerServices;
using WebSales.Domain.Entities;

namespace WebSales.Infra.Interfaces
{
    public interface ISaleRepository : IRepository<Sale>
    {
        Task<Sale> GetSaleBySaleNumberAsync(string saleNumber);
        Task<IEnumerable<Sale>> GetSalesListByDateAsync(DateTime date);
        Task<decimal> GetProfitByDateAsync(DateTime date);
        Task CancelSaleBySaleNumberAsync(string saleNumber);
        Task RevertCancelledSaleBySaleNumberAsync(string saleNumber);
    }
}
