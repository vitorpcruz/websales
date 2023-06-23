namespace WebSales.Domain.Notifications
{
    public static class CustomerNotifications
    {
        public const int FullNameMinLen = 2;
        public const int FullNameMaxLen = 200;

        public const int CpfLen = 11;
        public const int CnpjLen = 14;

        public static string FullNameIsNullOrWhiteSpace = $"The FullName cannot be null or white space.";
        public static string FullNameMinMaxLenNotification = $"The FullName must be between {FullNameMinLen} and {FullNameMaxLen} characters.";
        public static string DocumentInvalidNotification = "The document not is CPF or CNPJ.";
        public static string DocumentNullOrWhiteSpaceNotificatation = "The document cannot be null or white space.";
    }
}
