namespace WebSales.Services.DTOs
{
    public class CustomerDTO
    {
        public int? Id { get; private set; }
        public string? FullName { get; private set; }
        public string? Document { get; private set; }
        public bool? IsLegalPerson { get; private set; }
        public DateTime? CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }
    }
}
