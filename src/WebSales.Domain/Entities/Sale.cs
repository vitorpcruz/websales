namespace WebSales.Domain.Entities
{
    public class Sale : Entity
    {
        public string SaleNumber { get; private set; }
        public decimal ProductPriceAtMoment { get; private set; }
        public int ProductQuantity { get; private set; }
        public decimal Total { get; private set; }
        public bool SaleCancelled { get; private set; }

        public int? CustomerId { get; private set; }
        public int? ProductId { get; private set; }

        public Customer? Customer { get; private set; }
        public Product? Product { get; private set; }

        public Sale() { }

        public Sale(
            int id,
            string saleNumber,
            decimal productPriceAtMoment,
            int productQuantity,
            decimal total,
            bool saleCancelled,
            int? customerId,
            int? productId,
            DateTime createdAt,
            DateTime? modifiedAt) : base(id, createdAt, modifiedAt)
        {
            SaleNumber = saleNumber;
            ProductPriceAtMoment = productPriceAtMoment;
            ProductQuantity = productQuantity;
            Total = total;
            SaleCancelled = saleCancelled;
            CustomerId = customerId;
            ProductId = productId;
        }

        public Sale(
            decimal productPriceAtMoment,
            int productQuantity,
            decimal total,
            bool saleCancelled,
            int? customerId,
            int? productId)
        {
            SaleNumber = GenerateSaleNumber();
            ProductPriceAtMoment = productPriceAtMoment;
            ProductQuantity = productQuantity;
            Total = total;
            SaleCancelled = saleCancelled;
            CustomerId = customerId;
            ProductId = productId;
        }

        public void SaleValidations(Customer? customer)
        {
            SaleNumber = GenerateSaleNumber();
        }

        public void CancelSale()
        {
            SaleCancelled = true;
            UpdateEntity();
        }

        public string GenerateSaleNumber()
        {
            return DateTime.Now.ToString("o")
                .Replace("-", "")
                .Replace("T", "")
                .Replace(":", "")
                .Split('.')[0];
        }

        public void AddGenerateSaleNumber()
        {
            SaleNumber = GenerateSaleNumber();
        }
    }
}
