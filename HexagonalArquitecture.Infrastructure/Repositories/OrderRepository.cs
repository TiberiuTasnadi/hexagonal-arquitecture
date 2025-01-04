using HexagonalArquitecture.Application.Ports.Driven;
using HexagonalArquitecture.Domain.Entities;

namespace HexagonalArquitecture.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new();

        public Task<Order?> GetOrderByIdAsync(Guid id)
        {
            return Task.FromResult(_orders.FirstOrDefault(o => o.Id == id));
        }

        public Task SaveOrderAsync(Order order)
        {
            _orders.Add(order);
            return Task.CompletedTask;
        }
    }
}
