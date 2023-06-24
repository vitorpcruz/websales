using WebSales.Domain.Exceptions;
using WebSales.Domain.Notifications;
using WebSales.Domain.Utils;

namespace WebSales.Domain.Entities
{
    public class Customer : Entity
    {
        public string FullName { get; private set; }
        public string Document { get; private set; }
        public bool IsLegalPerson { get; private set; }

        public IEnumerable<Order> RegisterOrders { get; private set; }

        public Customer() { }

        private Customer(string fullName, string documentNumber)
        {
            CustomerValidations(fullName, documentNumber);
        }

        public void ValidateFullName(string? fullName)
        {
            DomainException.When(string.IsNullOrWhiteSpace(fullName),
                CustomerNotifications.FullNameIsNullOrWhiteSpace);

            DomainException.When(
                fullName.Length < CustomerNotifications.FullNameMinLen ||
                fullName.Length > CustomerNotifications.FullNameMaxLen,
                    CustomerNotifications.FullNameIsNullOrWhiteSpace);

            FullName = fullName;
        }
        

        public void CustomerValidations(string fullName, string documentNumber)
        {
            ValidateFullName(fullName);
            ValidateDocument(documentNumber);
        }

        private void ValidateDocument(string documentNumber)
        {
            DomainException.When(string.IsNullOrWhiteSpace(documentNumber),
                CustomerNotifications.DocumentNullOrWhiteSpaceNotificatation);

            DomainException.When(DocumentValidations.IsCpf(documentNumber) || DocumentValidations.IsCnpj(documentNumber),
                    CustomerNotifications.DocumentInvalidNotification);

            IsLegalPerson = DocumentValidations.IsCnpj(documentNumber) ? true : false;
            Document = documentNumber;
        }

        public void UpdateCustomer(string fullName, string documentNumber)
        {
            CustomerValidations(fullName, documentNumber);
        }

        public Customer Factory(string fullname, string document) => new(fullname, document);
    }
}
