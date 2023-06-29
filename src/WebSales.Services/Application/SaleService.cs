using AutoMapper;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;
using WebSales.Services.DTOs;
using WebSales.Services.Interfaces;

namespace WebSales.Services.Application
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IValueObjectsRepository _ValueObjectsRepository;
        private readonly IMapper _mapper;

        public SaleService(ISaleRepository saleRepository, IValueObjectsRepository ValueObjectsRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _ValueObjectsRepository = ValueObjectsRepository;
            _mapper = mapper;
        }

        public async Task<decimal> GetTodayProfitAsync()
        {
            return await _saleRepository.GetProfitByDateAsync(DateTime.Now);
        }

        public async Task RegisterSalesAsync(SaleDTO saleDto)
        {
            var sale = _mapper.Map<Sale>(saleDto);
            sale.AddGenerateSaleNumber();
            await _saleRepository.AddAsync(sale);
        }

        public async Task<SaleDTO> GetSaleBySaleNumber(string saleNumber)
        {
            var sale = await _saleRepository.GetSaleBySaleNumberAsync(saleNumber);
            var saleDto = _mapper.Map<SaleDTO>(sale);
            return saleDto;
        }

        public async Task CancelSaleBySaleNumberAsync(string saleNumber)
        {
            await _saleRepository.CancelSaleBySaleNumberAsync(saleNumber);
        }

        public async Task RevertCancelledSaleBySaleNumberAsync(string saleNumber)
        {
            await _saleRepository.RevertCancelledSaleBySaleNumberAsync(saleNumber);
        }

        public async Task DeleteSaleAsync(int id)
        {
            await _saleRepository.RemoveAsync(id);
        }
    }
}
