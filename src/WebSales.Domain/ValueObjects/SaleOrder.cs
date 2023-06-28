namespace WebSales.Domain.ValueObjects
{
    public class SaleOrder
    {
        public SaleOrder(string saleNumber, decimal total)
        {
            SaleNumber = saleNumber;
            Total = total;
        }

        public string SaleNumber { get; private set;}
        public decimal Total { get; private set; }
    }
}
