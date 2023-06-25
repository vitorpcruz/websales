using Bogus;
using Bogus.Extensions.Brazil;
using WebSales.Domain.Entities;

namespace WebSales.Infra.Mocks
{
    public static class CustomerMock
    {
        public static List<Customer> GeneratePersonMock()
        {
            int id = 1;
            var faker = new Faker<Customer>("pt_BR")
                .RuleFor(c => c.Id, f => id++)
                .RuleFor(c => c.FullName, f => f.Name.FullName())
                .RuleFor(c => c.Document, f => f.Person.Cpf());

            return faker.Generate(50).ToList();
        }
    }
}
