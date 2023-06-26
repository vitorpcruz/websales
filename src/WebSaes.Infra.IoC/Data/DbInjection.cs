using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebSales.Infra.Data;

namespace WebSales.IoC.Data
{
    public static class DbInjection
    {
        public static IServiceCollection AddDbInjection(this IServiceCollection services, string connectionString)
        {
            return services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}