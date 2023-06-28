namespace WebSales.Domain.ValueObjects
{
    public record BestSellingProduct(string Name, decimal? Total)
    {
        public string Name { get; private set; } = Name;
        public decimal? Total { get; private set; } = Total;
    }
}
