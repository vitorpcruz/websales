namespace WebSales.Domain.ValueObjects
{
    public record ProductSold(int? ProductId, string? ProductName)
    {
        public int? ProductId { get; private set; } = ProductId;
        public string? ProductName { get; private set; } = ProductName;
    }
}
