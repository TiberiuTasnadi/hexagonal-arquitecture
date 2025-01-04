namespace HexagonalArquitecture.Domain.Entities
{
    public class Order
    {
        public required Guid Id { get; set; }
        public required Guid CustomerId { get; set; }
        public List<OrderItem> Items { get; set; } = new();

        public decimal GetTotalPrice() =>
            Items.Sum(item => item.Price * item.Quantity);
    }
}
