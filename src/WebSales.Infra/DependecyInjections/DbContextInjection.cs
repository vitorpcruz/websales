using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebSales.Infra.Data;

namespace WebSales.Infra.DependecyInjections
{
    public static class DbContextInjection
    {
        public static IServiceCollection AddDatabaseContextInjection(this IServiceCollection services, string connectionString)
        {
            if (connectionString == null) throw new ArgumentNullException(nameof(connectionString));
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
