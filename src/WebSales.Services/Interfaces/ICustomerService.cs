using WebSales.Services.DTOs;

namespace WebSales.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerDTO> FindCustomerByIdAsync(int id);
        Task<bool> CheckIfDocumentExists(string document);
        Task AddCustomerAsync(CustomerDTO customerDto);
        Task RemoveCustomerByIdAsync(int id);
        Task UpdateCustomerAsync(CustomerDTO customerDto);
        Task<IEnumerable<CustomerDTO>> GetCustomersAsync();
        Task<int> GetCustomerIdByDocument(string document);
    }
}
