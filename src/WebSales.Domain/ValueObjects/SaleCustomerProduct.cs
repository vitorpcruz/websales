namespace WebSales.Domain.ValueObjects
{
    public record SaleCustomerProduct(IEnumerable<CustomerForSale> Customers, IEnumerable<ProductForSale> Products)
    {
        public IEnumerable<CustomerForSale> Customers { get; private set; } = Customers;
        public IEnumerable<ProductForSale> Products  { get; private set; } = Products;
    }

    public record ProductForSale(int? Id, string? Name, int? Quantity, decimal? Price)
    {
        public int? Id { get; private set; } = Id;
        public string? Name { get; private set; } = Name;
        public int? Quantity { get; private set; } = Quantity;
        public decimal? Price { get; private set; } = Price;
    }

    public record CustomerForSale(int? Id, string? FullName)
    {
        public int? Id { get; private set; } = Id;
        public string? FullName { get; private set; } = FullName;
    }
}
