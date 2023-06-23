using WebSales.Domain.Exceptions;
using WebSales.Domain.Notifications;
using WebSales.Domain.ValueObjects;

namespace WebSales.Domain.Entities
{
    public class Order : Entity
    {
        public string OrderNumber { get; private set; }
        public Customer Customer { get; private set; }
        public IEnumerable<ProductForSale> Products { get; private set; } 
        public double Total { get; private set; }

        public Order(Customer customer)
        {
            OrderValidations(customer);
        }

        public void OrderValidations(Customer? customer)
        {
            GenerateOrderNumber();
            ValidateCustomer(customer);
        }

        public void UpdateOrder(Customer? customer)
        {
            ValidateCustomer(customer);
            UpdateEntity();
        }

        public void ValidateCustomer(Customer? customer)
        {
            DomainException.When(customer == null, OrderNotifications.OrderNullNotification);
            Customer = customer;
        }

        public void GenerateOrderNumber()
        {
            OrderNumber = DateTime.Now.ToString("o")
                .Replace("-", "")
                .Replace("T", "")
                .Replace(":", "")
                .Split('.')[0];
        }

        public void CalculateTotal()
        {
            double sum = 0;
            foreach (ProductForSale products in Products) sum += products.SubTotal;
            Total = sum;
        }
    }
}
