namespace Domain.Anemic.Orders
{
    public sealed class LineItem
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }

        public decimal Price { get; set; }

        public string Currency { get; set; } = string.Empty;
    }
}
