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

        public IEnumerable<Sale> CustomerSales { get; set; }

        public Customer() { }

        public Customer(string fullName, string document)
        {
            CustomerValidations(fullName, document);
        }

        public Customer(int id, string fullName, string document) : base(id)
        {
            CustomerValidations(fullName, document);
        }

        public Customer(int id, string fullName, string document, DateTime createdAt, DateTime? modifiedAt) : base(id, createdAt, modifiedAt)
        {
            CustomerValidations(fullName, document);
        }

        public void ValidateFullName(string? fullName)
        {
            DomainException.When(string.IsNullOrWhiteSpace(fullName),
                CustomerNotifications.FullNameIsNullOrWhiteSpace);

            DomainException.When(fullName.Length < CustomerNotifications.FullNameMinLen ||
                fullName.Length > CustomerNotifications.FullNameMaxLen,
                    CustomerNotifications.FullNameIsNullOrWhiteSpace);

            FullName = fullName;
        }
        

        public void CustomerValidations(string fullName, string document)
        {
            ValidateFullName(fullName);
            ValidateDocument(document);
        }

        private void ValidateDocument(string document)
        {
            DomainException.When(string.IsNullOrWhiteSpace(document),
                CustomerNotifications.DocumentNullOrWhiteSpaceNotificatation);

            DomainException.When(DocumentValidations.IsCpf(document) && DocumentValidations.IsCnpj(document),
                    CustomerNotifications.DocumentInvalidNotification);

            IsLegalPerson = DocumentValidations.IsCnpj(document);
            Document = document;
        }

        public void UpdateCustomer(string fullName, string document)
        {
            CustomerValidations(fullName, document);
        }
    }
}
