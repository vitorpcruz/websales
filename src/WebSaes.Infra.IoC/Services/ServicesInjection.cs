using Microsoft.Extensions.DependencyInjection;
using WebSales.Services.Application;
using WebSales.Services.Configuration;
using WebSales.Services.Interfaces;

namespace WebSales.IoC.Services
{
    public static class ServicesInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfig));
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }

}
