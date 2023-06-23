using WebSales.Domain.Entities;
using WebSales.Domain.Exceptions;
using WebSales.Domain.Notifications;

namespace WebSales.Domain.ValueObjects
{
    public class ProductForSale
    { 
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public double SubTotal { get; private set; }
        public ProductForSale(Product? product, int quantity) => ProductForSaleValidations(product, quantity);

        public void ProductForSaleValidations(Product product, int quantity)
        {
            ValidateProduct(product);
            ValidateQuantity(quantity);
            CalculateSubtotal();
        }

        public void CalculateSubtotal() => SubTotal = Product.Price * Quantity;

        public void ValidateProduct(Product? product)
        {
            DomainException.When(product == null, ProductForOrderNotifications.ProductNullNotification);
            Product = product;
        }

        public void ValidateQuantity(int quantity)
        {
            DomainException.When(quantity == null ||
                quantity < ProductNotifications.QuantityMinValue,
                    ProductNotifications.QuantityMinValueNotification);
            Quantity = quantity;
        }

        public void UpdateProductForSale(Product? product, int quantity)
            => ProductForSaleValidations(product, quantity);

        public static ProductForSale Factory(Product? product, int quantity)
            => new(product, quantity);
    }
}
