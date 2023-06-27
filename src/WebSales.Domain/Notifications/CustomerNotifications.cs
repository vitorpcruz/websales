using System.Runtime.CompilerServices;

namespace WebSales.Domain.Notifications
{
    public static class CustomerNotifications
    {
        public const int FullNameMinLen = 2;
        public const int FullNameMaxLen = 200;

        public const int CpfLen = 15;
        public const int CnpjLen = 18;

        public static string FullNameIsNullOrWhiteSpace = $"The FullName cannot be null or white space.";
        public static string FullNameMinMaxLenNotification = $"The FullName must be between {FullNameMinLen} and {FullNameMaxLen} characters.";
        public static string DocumentInvalidNotification = "The document not is CPF or CNPJ.";
        public static string DocumentNullOrWhiteSpaceNotification = "The document cannot be null or white space.";

        public static string DocumentCpfInvalid = "CPF incorrect: Use the pattern XXX.XXX.XXX-XX";
        public static string DocumentCnpjInvalid = "CNPJ incorrect: Use the pattern XX.XXX.XXX/XXXX-XX";
    }
}
