using Bogus;
using WebSales.Domain.Entities;

namespace WebSales.Infra.Mocks
{
    public static class SaleMock
    {
        public static List<Sale> GenerateSaleMock()
        {
            int id = 1;
            var faker = new Faker<Sale>("pt_BR")
                .RuleFor(s => s.Id, f => id++)
                .RuleFor(s => s.SaleNumber, (f, s) => s.GenerateSaleNumber())
                .RuleFor(s => s.Quantity, f => f.Random.Int(1, 20))
                .RuleFor(s => s.Total, f => f.Random.Double(1.0, 20.0))
                .RuleFor(s => s.CustomerId, f => f.Random.Int(1, 20))
                .RuleFor(s => s.ProductId, f => f.Random.Int(1, 20));

            return faker.Generate(50).ToList();
        }

    }

}
