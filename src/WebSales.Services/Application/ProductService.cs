using AutoMapper;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;
using WebSales.Services.DTOs;
using WebSales.Services.Interfaces;

namespace WebSales.Services.Application
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task AddProductAsync(ProductDTO productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.AddAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _productRepository.FindByIdAsync(id);
            await _productRepository.RemoveAsync(product);
        }

        public async Task<ProductDTO> FindProductByIdAsync(int id)
        {
            var product = await _productRepository.FindByIdAsync(id);
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            var products = await _productRepository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task UpdateProductAsync(ProductDTO productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            product.UpdateProduct(productDto.Name, product.Description, product.Price, product.Quantity);
            await _productRepository.UpdateAsync(product);
        }

        public async Task<IEnumerable<ProductDTO>> ProductsPurchasedByCustomerAsync(int id)
        {
            var products = await _productRepository.ProductsPurchasedByCustomerAsync(id);
            var productsDto = _mapper.Map<IEnumerable<ProductDTO>>(products);
            return productsDto;
        }
    }
}
