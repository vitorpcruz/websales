using AutoMapper;
using WebSales.Domain.Entities;
using WebSales.Domain.ValueObjects;
using WebSales.Services.DTOs;

namespace WebSales.Services.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Sale, SaleDTO>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();

            CreateMap<ProductSold, ProductSoldDTO>().ReverseMap();
            CreateMap<SaleComplete, SaleCompleteDTO>().ReverseMap();
            CreateMap<PurchaseByValidCustomer, PurchaseByValidCustomerDTO>().ReverseMap();
            CreateMap<BestSellingProduct, BestSellingProductDTO>().ReverseMap();

            CreateMap<CustomerForSale, CustomerForSaleDTO>().ReverseMap();
            CreateMap<ProductForSale, ProductForSaleDTO>().ReverseMap();
            CreateMap<CustomerForSale, CustomerForSaleDTO>().ReverseMap();
            CreateMap<SaleCustomerProduct, SaleCustomerProductDTO>().ReverseMap();
        }
    }
}
