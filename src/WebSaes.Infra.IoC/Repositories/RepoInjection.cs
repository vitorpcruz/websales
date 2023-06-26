using Microsoft.Extensions.DependencyInjection;
using WebSales.Infra.Interfaces;
using WebSales.Infra.Repositories;

namespace WebSales.IoC.Repositories
{
    public static class RepoInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();

            services.AddTransient<IProductSoldRepository, ProductSoldRepository>();

            return services;
        }
    }
}
