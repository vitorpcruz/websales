namespace WebSales.Domain.ValueObjects
{
    public record SaleComplete(string? SaleNumber, decimal? ProductPriceAtMoment, int? ProductQuantity, decimal? Total, string? ProductName, string? CustomerFullName)
    {
        public string? SaleNumber { get; private set; } = SaleNumber;
        public decimal? ProductPriceAtMoment { get; private set; } = ProductPriceAtMoment;
        public int? ProductQuantity { get; private set; } = ProductQuantity;
        public decimal? Total { get; private set; } = Total;
        public string? ProductName { get; private set; } = ProductName;
        public string? CustomerFullName { get; private set; } = CustomerFullName;
    }
}
