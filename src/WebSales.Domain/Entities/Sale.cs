namespace WebSales.Domain.Entities
{
    public class Sale : Entity
    {
        public string SaleNumber { get; private set; }
        public double ProductPriceAtMoment { get; private set; }
        public int ProductQuantity { get; private set; }
        public double Total { get; private set; }
        public bool SaleCancelled { get; private set; }

        public int? CustomerId { get; private set; }
        public int? ProductId { get; private set; }

        public Customer? Customer { get; private set; }
        public Product? Product { get; private set; }

        public Sale() { }

        public Sale(
            string saleNumber,
            double productPriceAtMoment,
            int productQuantity,
            double total,
            bool saleCancelled,
            int? customerId,
            int? productId)
        {
            SaleNumber = saleNumber;
            ProductPriceAtMoment = productPriceAtMoment;
            ProductQuantity = productQuantity;
            Total = total;
            SaleCancelled = saleCancelled;
            CustomerId = customerId;
            ProductId = productId;
        }

        public Sale(int id,
                    string saleNumber,
                    double productPriceAtMoment,
                    int productQuantity,
                    double total,
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

        public void SaleValidations(Customer? customer)
        {
            SaleNumber = GenerateSaleNumber();
            //ValidateCustomer(customer);
        }

        public void UpdateSale(Customer? customer)
        {
            //ValidateCustomer(customer);
        }

        //public void ValidateCustomer(Customer? customer)
        //{
        //    DomainException.When(customer == null, OrderNotifications.OrderNullNotification);
        //    Customer = customer;
        //}

        public string GenerateSaleNumber()
        {
            return DateTime.Now.ToString("o")
                .Replace("-", "")
                .Replace("T", "")
                .Replace(":", "")
                .Split('.')[0];
        }

        //public static Sale Factory(int id, string saleNumber, int customerId, int productId, int productQuantity, double total, DateTime createdAt, DateTime modifiedAt)
            //=> new(id, saleNumber, customerId, productId, productQuantity, total, createdAt, modifiedAt);
    }
}
