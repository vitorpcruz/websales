using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebSales.Infra.Data;

namespace WebSales.Infra.DependecyInjections
{
    public static class DbContextInjection
    {
        public static IServiceCollection AddDatabaseContextInjection(this IServiceCollection services, string connectionString)
        {
            return services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
