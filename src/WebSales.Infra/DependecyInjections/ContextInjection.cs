using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebSales.Infra.Contexts;

namespace WebSales.Infra.DependecyInjections
{
    public static class ContextInjection
    {
        public static IServiceCollection AddDatabaseInjection(this IServiceCollection services, string connectionString)
        {
            if (connectionString == null) throw new ArgumentNullException(nameof(connectionString));
            services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
