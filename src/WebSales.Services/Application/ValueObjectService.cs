using AutoMapper;
using WebSales.Infra.Interfaces;
using WebSales.Services.DTOs;
using WebSales.Services.Interfaces;

namespace WebSales.Services.Application
{
    public class ValueObjectService : IValueObjectService
    {
        private readonly IValueObjectsRepository _repository;
        private readonly IMapper _mapper;

        public ValueObjectService(IValueObjectsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SaleCompleteDTO>> GetAllSalesByDateAsync(DateTime date)
        {
            var list = await _repository.GetAllSalesByDateAsync(date);
            var listDto = _mapper.Map<IEnumerable<SaleCompleteDTO>>(list);
            return listDto;
        }

        public async Task<IEnumerable<BestSellingProductDTO>> BestSeillingProductsAsync()
        {
            var list = await _repository.BestSeillingProductsAsync();
            var listDto = _mapper.Map<IEnumerable<BestSellingProductDTO>>(list);
            return listDto;
        }
        public async Task<IEnumerable<ProductSoldDTO>> ProductsPurchasedByCustomerAsync(int id)
        {
            var list = await _repository.ProductsPurchasedByCustomerAsync(id);
            var listDto = _mapper.Map<IEnumerable<ProductSoldDTO>>(list);
            return listDto;
        }

        public async Task<IEnumerable<PurchaseByValidCustomerDTO>> PurchasesMadebyValidCustomers()
        {
            var list = await _repository.PurchasesMadebyValidCustomers();
            var listDto = _mapper.Map<IEnumerable<PurchaseByValidCustomerDTO>>(list);
            return listDto;
        }

        public async Task<SaleCustomerProductDTO> GetCustomersAndProductsForSale()
        {
            var saleCustomerProduct = await _repository.GetCustomersAndProductsForSale();
            var saleCustomerProductDto = _mapper.Map<SaleCustomerProductDTO>(saleCustomerProduct);
            saleCustomerProductDto.CustomersForSaleDTO = _mapper.Map<IEnumerable<CustomerForSaleDTO>>(saleCustomerProduct.Customers);
            saleCustomerProductDto.ProductsForSaleDTO = _mapper.Map<IEnumerable<ProductForSaleDTO>>(saleCustomerProduct.Products);
            return saleCustomerProductDto;
        }
    }
}
