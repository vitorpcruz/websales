using Bogus;
using Bogus.Extensions.Brazil;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;
using WebSales.Infra.Repositories;

namespace WebSales.Tests.Infastrucutre
{
    public class CustomerRepositoryTests
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly Faker _faker;
        public CustomerRepositoryTests()
        {
            _customerRepository = new CustomerRepository();
            _faker = new Faker("pt_BR");
        }

        [Fact]
        public async void CustomerRepository_FindByIdAsync_ValidId_ReturnAValidCustomer()
        {
            int id = 1;
            Customer? customer = await _customerRepository.FindByIdAsync(id);
            Assert.NotNull(customer);
            Assert.IsType<Customer>(customer);
        }

        [Fact]
        public async void CustomerRepository_FindByIdAsync_InvalidId_ReturnNullCustomer()
        {
            int id = 100;
            Customer? customer = await _customerRepository.FindByIdAsync(id);
            Assert.Null(customer);
        }

        [Fact]
        public async void CustomerRepository_AddAsync_MustAddAValidCustomer()
        {
            var customer = new Customer(
                _faker.Name.FullName(),
                _faker.Person.Cpf()
            );

            var result = await _customerRepository.AddAsync(customer);
            Assert.IsType<int>(result);
        }
    }
}