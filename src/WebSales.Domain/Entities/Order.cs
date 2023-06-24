using WebSales.Domain.Exceptions;
using WebSales.Domain.Notifications;

namespace WebSales.Domain.Entities
{
    public class Sale : Entity
    {
        public string OrderNumber { get; private set; }
        public int CustomerId { get; private set; }
        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public double Total { get; private set; }

        public Customer Customer { get; private set; }
        public Product Product { get; private set; }

        public Sale() { }

        public Sale(Customer customer)
        {
            SaleValidations(customer);
        }

        public void SaleValidations(Customer? customer)
        {
            GenerateSaleNumber();
            ValidateCustomer(customer);
        }

        public void UpdateSale(Customer? customer)
        {
            ValidateCustomer(customer);
        }

        public void ValidateCustomer(Customer? customer)
        {
            DomainException.When(customer == null, OrderNotifications.OrderNullNotification);
            Customer = customer;
        }

        public void GenerateSaleNumber()
        {
            OrderNumber = DateTime.Now.ToString("o")
                .Replace("-", "")
                .Replace("T", "")
                .Replace(":", "")
                .Split('.')[0];
        }
    }
}
