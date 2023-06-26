using WebSales.Domain.Exceptions;
using WebSales.Domain.Notifications;

namespace WebSales.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; private set; }
        public string? Description { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public IEnumerable<Sale> ProductsSold { get; private set; }

        public Product() { }

        public Product(string name, string? description, decimal price, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        private void ValidateName(string name)
        {
            DomainException.When(string.IsNullOrWhiteSpace(name), 
                ProductNotifications.NameNullOrEmptyNotification);

            DomainException.When(name.Length < ProductNotifications.NameMinLen ||
                name.Length > ProductNotifications.NameMaxLen, 
                    ProductNotifications.NameLenNotification);

            Name = name;
        }

        private void ValidateDescription(string description)
        {
            DomainException.When(description.Length > ProductNotifications.DescriptionMaxLen, 
                ProductNotifications.DescriptionMaxLenNotification);

            Description = description;
        }

        private void ValidatePrice(decimal price)
        {
            //DomainException.When(price < ProductNotifications.PriceMinValue ||
            //    price > ProductNotifications.PriceMaxValue, 
            //        ProductNotifications.PriceMinMaxValueNotification);

            Price = price;
        }

        private void ValidateQuantity(int quantity)
        {
            DomainException.When(quantity < ProductNotifications.QuantityMinValue,
                ProductNotifications.QuantityMinValueNotification);
            Quantity = quantity;
        }

        //private void UpdateProduct(string? name,
        //                            string? description,
        //                            decimal price = ProductNotifications.PriceMinValue,
        //                            int quantity = ProductNotifications.QuantityMinValue
        //    )
        //{
        //    ValidateName(name);
        //    ValidateDescription(description);
        //    ValidatePrice(price);
        //    ValidateQuantity(quantity);
        //    //UpdateEntity();
        //}
    }
}
