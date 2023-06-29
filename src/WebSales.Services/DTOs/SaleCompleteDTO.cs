namespace WebSales.Services.DTOs
{
    public class SaleCompleteDTO
    {
        public string SaleNumber { get;  set; }
        public decimal ProductPriceAtMoment { get;  set; }
        public int ProductQuantity { get;  set; }
        public decimal Total { get;  set; }
        public string? ProductName { get;  set; }
        public string? CustomerFullName { get;  set; }
        public bool SaleCancelled { get;  set; }
    }
}
