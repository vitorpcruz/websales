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
                .RuleFor(s => s.CustomerId, f => f.Random.Int(1, 20))
                .RuleFor(s => s.ProductId, f => f.Random.Int(1, 20))
                .RuleFor(s => s.ProductPriceAtMoment, f => f.Random.Decimal(1, 20))
                .RuleFor(s => s.ProductQuantity, f => f.Random.Int(1, 20))
                .RuleFor(s => s.Total, (f, s) => s.ProductPriceAtMoment * s.ProductQuantity)
                .RuleFor(s => s.SaleCancelled, false);

            return faker.Generate(50).ToList();
        }
    }
}
