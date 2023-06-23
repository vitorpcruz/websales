namespace WebSales.Domain.Interfaces
{
    public interface ICustomerDocument
    {
        public string DocumentNumber { get; }
        void ValidateDocumentNumber(string? documentNumber);
    }
}
