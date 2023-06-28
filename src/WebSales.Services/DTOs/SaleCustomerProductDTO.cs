namespace WebSales.Services.DTOs
{
    public class SaleCustomerProductDTO
    {
        public IEnumerable<CustomerForSaleDTO>?  CustomersForSaleDTO { get; set; }
        public IEnumerable<ProductForSaleDTO>? ProductsForSaleDTO { get; set; }
    }
}
