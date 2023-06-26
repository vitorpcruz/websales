namespace WebSales.Services.DTOs
{
    public class ProductDTO
    {
        public int? Id { get; private set; }
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public decimal? Price { get; private set; }
        public DateTime? CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }
    }
}
