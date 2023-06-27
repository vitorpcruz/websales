namespace WebSales.Domain.Notifications
{
    public static class ProductNotifications
    {
        public const int NameMinLen = 3;
        public const int NameMaxLen = 100;
        public const int DescriptionMaxLen = 1000;
        public const int QuantityMinValue = 0;

        public const decimal PriceMaxValue = 999999999;

        public static string NameLenNotification = $"The name must be between {NameMinLen} and {NameMaxLen}.";
        public static string NameNullOrEmptyNotification = $"The name must be between {NameMinLen} and {NameMaxLen}.";
        public static string DescriptionMaxLenNotification = $"The description must be up to {DescriptionMaxLen} characters.";
        public static string PriceMinMaxValueNotification = $"The price must be between 0 and {PriceMaxValue} characters.";
        public static string QuantityMinValueNotification = $"The Product Quantity must be greater than or equal to {QuantityMinValue}.";
    }
}
