namespace WebSales.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string strError)
            : base (strError) { }

        public static void When(bool condition, string strError)
        {
            if (condition) throw new DomainException(strError);
        }
    }
}
