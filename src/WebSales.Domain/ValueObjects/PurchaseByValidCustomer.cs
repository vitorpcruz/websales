namespace WebSales.Domain.ValueObjects
{
    public record PurchaseByValidCustomer(int? CustomerId, string? CustomerFullName, string? CustomerDocument, string? SaleNumber)
    {
        public int? CustomerId { get; private set; } = CustomerId;
        public string? CustomerFullName { get; private set; } = CustomerFullName;
        public string? CustomerDocument { get; private set; } = CustomerDocument;
        public string? SaleNumber { get; private set; } = SaleNumber;
    }
}
