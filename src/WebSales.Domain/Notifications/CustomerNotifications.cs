namespace WebSales.Domain.Notifications
{
    public static class CustomerNotifications
    {
        public const int FullNameMinLen = 2;
        public const int FullNameMaxLen = 200;

        public static string FullNameIsNullOrWhiteSpace = $"The FullName cannot be null or white space.";
        public static string FullNameMinMaxLenNotification = $"The FullName must be between {FullNameMinLen} and {FullNameMaxLen} characters.";
    }
}
