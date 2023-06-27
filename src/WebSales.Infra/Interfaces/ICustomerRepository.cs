using WebSales.Domain.Entities;

namespace WebSales.Infra.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer> 
    {
        Task<bool> CheckIfDocumentExists(string document);
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<IEnumerable<Customer>> GetCustomersByFullNameAsync(string fullName);
        Task<IEnumerable<Customer>> GetCustomersByDocumentAsync(string document);
        Task<int> GetCustomerIdByDocument(string document);
    }
}
