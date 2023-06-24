using WebSales.Domain.Entities;

namespace WebSales.Infra.Interfaces
{
    public interface ISaleRepository : IRepository<Sale>
    {
        Task<Sale> GetSalesBySaleNumberAsync(string orderNumber);
        Task<IEnumerable<Sale>> GetSaleByDateAsync(DateTime date);
        Task<double> GetProfitabilityByDateAsync(DateTime date);
    }
}
