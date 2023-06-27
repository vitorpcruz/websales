using AutoMapper;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;
using WebSales.Services.DTOs;
using WebSales.Services.Interfaces;

namespace WebSales.Services.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CustomerDTO>> GetCustomersAsync()
        {
            var customers = await _customerRepository.GetCustomersAsync();
            var customersDto = _mapper.Map<IEnumerable<CustomerDTO>>(customers);
            return customersDto;
        }

        public async Task AddCustomerAsync(CustomerDTO customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            await _customerRepository.AddAsync(customer);
        }

        public async Task<CustomerDTO> FindCustomerByIdAsync(int id)
        {
            var customer = await _customerRepository.FindByIdAsync(id);
            var customerDto = _mapper.Map<CustomerDTO>(customer);
            return customerDto;
        }

        public async Task RemoveCustomerByIdAsync(int id)
        {
            await _customerRepository.RemoveAsync(id);
        }

        public async Task UpdateCustomerAsync(CustomerDTO customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            customer.UpdateCustomer(customer.FullName, customer.Document);
            await _customerRepository.UpdateAsync(customer);
        }

        public async Task<bool> CheckIfDocumentExists(string document)
        {
            return await _customerRepository.CheckIfDocumentExists(document);
        }

        public async Task<int> GetCustomerIdByDocument(string document)
        {
            return await _customerRepository.GetCustomerIdByDocument(document);
        }
    }
}
