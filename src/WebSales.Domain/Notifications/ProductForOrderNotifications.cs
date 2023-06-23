namespace WebSales.Domain.Notifications
{
    public static class ProductForOrderNotifications
    {
        public static string ProductNullNotification = $"The product cannot be null.";
        public static string ProductQuantityNullNotification = $"The quantity cannot be null or below than 0.";
    }
}
