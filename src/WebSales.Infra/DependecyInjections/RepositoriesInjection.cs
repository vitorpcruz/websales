using Microsoft.Extensions.DependencyInjection;
using WebSales.Infra.Interfaces;
using WebSales.Infra.Repositories;

namespace WebSales.Infra.DependecyInjections
{
    public static class RepositoriesInjection
    {
        public static IServiceCollection AddRepositoriesInjection(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            return services;
        }
    }
}
