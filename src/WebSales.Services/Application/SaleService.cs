using AutoMapper;
using System.Security.Cryptography.X509Certificates;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;
using WebSales.Infra.Repositories;
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
    }
}
