using HexagonalArquitecture.Domain.Entities;

namespace HexagonalArquitecture.Application.Ports.Driven
{
    public interface IOrderRepository
    {
        Task<Order?> GetOrderByIdAsync(Guid id);
        Task SaveOrderAsync(Order order);
    }
}
