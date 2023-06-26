using AutoMapper;
using WebSales.Domain.Entities;
using WebSales.Services.DTOs;

namespace WebSales.Services.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //CreateMap<Sale, SaleViewModel>().ReverseMap();
            //CreateMap<Customer, CustomerViewModel>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
