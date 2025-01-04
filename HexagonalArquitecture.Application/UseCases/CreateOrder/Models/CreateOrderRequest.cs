using HexagonalArquitecture.Application.Models;

namespace HexagonalArquitecture.Application.Adapters.CreateOrder.Models
{
    public class CreateOrderRequest
    {
        public Guid CustomerId { get; set; }
        public List<OrderItemDto> Items { get; set; } = new();
    }
}
