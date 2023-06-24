using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;

namespace WebSales.Infra.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        public Task AddAsync(Sale entity)
        {
            throw new NotImplementedException();
        }

        public Task<Sale> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<double> GetProfitabilityByDateAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Sale>> GetSaleByDateAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<Sale> GetSalesBySaleNumberAsync(string orderNumber)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Sale entity)
        {
            throw new NotImplementedException();
        }
    }
}
