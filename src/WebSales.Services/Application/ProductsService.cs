using AutoMapper;
using WebSales.Infra.Interfaces;
using WebSales.Services.DTOs;

namespace WebSales.Services.Application
{
    public class ProductsService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductsService(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<ProductDTO> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.FindByIdAsync(id);
            return _mapper.Map<ProductDTO>(product);
        }
    }
}
