using WebSales.Infra.Interfaces;
using WebSales.Infra.Repositories;
using WebSales.Services.Interfaces;

namespace WebSales.Services.Application
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IValueObjectsRepository _ValueObjectsRepository;

        public SaleService(ISaleRepository saleRepository, IValueObjectsRepository ValueObjectsRepository)
        {
            _saleRepository = saleRepository;
            _ValueObjectsRepository = ValueObjectsRepository;
        }

        public async Task<decimal> GetTodayProfitAsync()
        {
            return await _saleRepository.GetProfitByDateAsync(DateTime.Now);
        }
    }
}
