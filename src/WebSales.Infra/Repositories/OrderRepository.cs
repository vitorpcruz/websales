using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;

namespace WebSales.Infra.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task AddAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<Order> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderByOrderNumberAsync(string? orderNumber)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetOrdersByDateAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<double> GetTotalSaledForDay(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
