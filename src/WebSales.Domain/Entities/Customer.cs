using WebSales.Domain.Exceptions;
using WebSales.Domain.Notifications;
using WebSales.Domain.ValueObjects;

namespace WebSales.Domain.Entities
{
    public class Customer : Entity
    {
        public string FullName { get; private set; }
        public bool IsLegalPerson { get; private set; }
        public CustomerDocument Document { get; private set; }
        public IEnumerable<Product> ProductsPurchased { get; private set; }

        private Customer(string? fullName = null, string? documentNumber = null)
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
        
        public void ValidateLegalPerson() => IsLegalPerson = Document.DocumentNumber.Length == 14;

        public void CustomerValidations(string? fullName = null, string? documentNumber = null)
        {
            ValidateFullName(fullName);
            Document = new(documentNumber);
            ValidateLegalPerson();
        }

        public void UpdateCustomer(string? fullName = null, string? documentNumber = null)
        {
            CustomerValidations(fullName, documentNumber);
            UpdateEntity();
        }

        public Customer Factory(string? fullname, string? document) => new(fullname, document);
    }
}
