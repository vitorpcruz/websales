using WebSales.Domain.ValueObjects;

namespace WebSales.Services.DTOs
{
    public class SaleDTO
    {
        public int? Id { get; set; }
        public string? SaleNumber { get; set; }
        public decimal? ProductPriceAtMoment { get; set; }
        public int? ProductQuantity { get; set; }
        public decimal? Total { get; set; }
        public bool SaleCancelled { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public IEnumerable<CustomerForSaleDTO>? CustomersDTO { get; set; }
        public IEnumerable<ProductForSaleDTO>? ProductsDTO { get; set; }
    }
}
