using Bogus;
using WebSales.Domain.Entities;

namespace WebSales.Infra.Mocks
{
    public static class ProductMock
    {
        public static List<Product> GenerateProductMock()
        {
            int id = 1;
            var faker = new Faker<Product>("pt_BR")
                .RuleFor(p => p.Id, f => id++)
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.Price, f => f.Random.Double(1.0, 100.0))
                .RuleFor(p => p.Quantity, f => f.Random.Int(0, 100));

            return faker.Generate(50).ToList();
        }
    }
}
