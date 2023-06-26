namespace WebSales.Domain.ValueObjects
{
    public class ProductSold
    {
        public ProductSold(int productId, string productName, string? saleNumber, decimal? productPriceAtMoment, int? productQuantity, decimal? total, bool? saleCancelled, DateTime? createdAt, DateTime? modifiedAt)
        {
            ProductId = productId;
            ProductName = productName;
            SaleNumber = saleNumber;
            ProductPriceAtMoment = productPriceAtMoment;
            ProductQuantity = productQuantity;
            Total = total;
            SaleCancelled = saleCancelled;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; private set; }
        public string? SaleNumber { get; private set; }
        public decimal? ProductPriceAtMoment { get; private set; }
        public int? ProductQuantity { get; private set; }
        public decimal? Total { get; private set; }
        public bool? SaleCancelled { get; private set; }
        public DateTime? CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }
    }
}
