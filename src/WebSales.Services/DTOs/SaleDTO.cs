namespace WebSales.Services.DTOs
{
    public class SaleDTO
    {
        public int? Id { get; private set; }
        public string? SaleNumber { get; private set; }
        public decimal? ProductPriceAtMoment { get; private set; }
        public int? ProductQuantity { get; private set; }
        public decimal? Total { get; private set; }
        public bool SaleCancelled { get; private set; }
        public int? CustomerId { get; private set; }
        public int? ProductId { get; private set; }
        public DateTime? CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }
    }
}
