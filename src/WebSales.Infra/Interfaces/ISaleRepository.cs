using WebSales.Domain.Entities;

namespace WebSales.Infra.Interfaces
{
    public interface ISaleRepository : IRepository<Sale>
    {
        Task<IEnumerable<Sale>> GetSalesBySaleNumberAsync(string saleNumber);
        Task<IEnumerable<Sale>> GetSalesListByDateAsync(DateTime date);
        Task<double> GetProfitByDateAsync(DateTime date);
    }
}
