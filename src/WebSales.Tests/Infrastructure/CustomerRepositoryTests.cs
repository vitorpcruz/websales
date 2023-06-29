using Bogus;
using Bogus.Extensions.Brazil;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;
using WebSales.Infra.Repositories;
using Xunit.Abstractions;

namespace WebSales.Tests.Infastrucutre
{
    public class CustomerRepositoryTests
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ITestOutputHelper _output;
        private readonly Faker _faker;
        
        public CustomerRepositoryTests(ITestOutputHelper output)
        {
            _customerRepository = new CustomerRepository();
            _faker = new Faker("pt_BR");
            _output = output;
        }

        [Fact]
        public async void CustomerRepository_FindByIdAsync_ValidId_ReturnAValidCustomer()
        {
            int id = 1;
            Customer customer = await _customerRepository.FindByIdAsync(id);

            Assert.NotNull(customer);
            Assert.IsType<Customer>(customer);
        }

        [Fact]
        public async void CustomerRepository_FindByIdAsync_InvalidId_ReturnNullCustomer()
        {
            int id = 1200;
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

            await _customerRepository.AddAsync(customer);
            IEnumerable<Customer> users = await _customerRepository.GetCustomersByDocumentAsync(_faker.Person.Cpf());
            var firstUser = users.First();

            Assert.Equal(customer.FullName, firstUser.FullName);
            Assert.Equal(customer.Document, firstUser.Document);
        }

        [Fact]
        public async void CustomerRepository_RemoveAsync_MustRemoveRegisterIfExists()
        {
            int id = new Random().Next(1,21);
            await _customerRepository.RemoveAsync(id);
            var result = await _customerRepository.FindByIdAsync(id);
            Assert.Null(result);
        }

        [Fact]
        public async void CustomerRepository_CheckIfDocumentExists_MustReturnTrueForAValidDocument()
        {
            var customer = new Customer(_faker.Name.FullName(), _faker.Person.Cpf());
            await _customerRepository.AddAsync(customer);
            var documentExists = _customerRepository.CheckIfDocumentExists(customer.Document);
            Assert.True(documentExists.Result);
        }

        [Fact]
        public async void CustomerRepository_CheckIfDocumentExists_MustReturnFalseForInvalidDocument()
        {
            var documentExists = _customerRepository.CheckIfDocumentExists(_faker.Person.Cpf());
            Assert.False(documentExists.Result);
        }

        [Fact]
        public async void CustomerRepository_GetCustomersAsync_MustReturnCustomerList()
        {
            var customers = await _customerRepository.GetCustomersAsync();
            Assert.NotNull(customers);
            Assert.True(customers.Count() >= 1);
        }

        [Fact]
        public async void CustomerRepository_GetCustomersByFullNameAsync_MustReturnCustomerList()
        {
            var name = "la";
            var customers = await _customerRepository.GetCustomersByFullNameAsync(name);
            Assert.NotNull(customers);
            Assert.True(customers.Count() >= 1);
        }

        [Fact]
        public async void CustomerRepository_GetCustomersByDocumentAsync_MustReturnCustomerList()
        {
            var partDocument = "20";
            var customers = await _customerRepository.GetCustomersByDocumentAsync(partDocument);
            Assert.NotNull(customers);
            Assert.True(customers.Any());
        }

        [Fact]
        public async void CustomerRepository_UpdateAsync_MustUpdateCustomer()
        {
            var oldName = _faker.Name.FullName();
            var newName = _faker.Name.FullName();
            var customer = new Customer(oldName, _faker.Person.Cpf());

            await _customerRepository.AddAsync(customer);
            IEnumerable<Customer> users = await _customerRepository.GetCustomersByFullNameAsync(oldName);
            
            var firstQuery = users.First();
            firstQuery.UpdateCustomer(newName, firstQuery.Document);
            await _customerRepository.UpdateAsync(firstQuery);

            Assert.NotEqual(firstQuery.FullName, oldName);
        }
    }
}