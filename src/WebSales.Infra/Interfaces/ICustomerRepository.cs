using WebSales.Domain.Entities;

namespace WebSales.Infra.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer> 
    {
        Task<bool> CheckIfDocumentExists(string document);
    }
}
