namespace WebSales.Domain.Notifications
{
    public static class CustomerDocumentNotifications
    {
        public const int CpfLen = 11;
        public const int CnpjLen = 14;

        public static string DocumentInvalidNotification = "The document not is CPF or CNPJ.";
        public static string DocumentNullOrWhiteSpaceNotificatation = "The document cannot be null or white space.";
    }
}
