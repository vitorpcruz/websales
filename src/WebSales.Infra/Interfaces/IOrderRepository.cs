using WebSales.Domain.Entities;

namespace WebSales.Infra.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> GetOrderByOrderNumberAsync(string? orderNumber);
        Task<IEnumerable<Order>> GetOrdersByDateAsync(DateTime date);
        Task<double> GetTotalSaledForDay(DateTime date);
    }
}
