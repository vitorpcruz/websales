namespace WebSales.Services.DTOs
{
    public class PurchaseByValidCustomerDTO
    {
        public int CustomerId { get; set; } 
        public string CustomerFullName { get; set; }
        public string CustomerDocument { get; set; }
        public string SaleNumber { get; set; }
    }
}
