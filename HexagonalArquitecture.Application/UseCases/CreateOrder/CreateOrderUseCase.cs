using HexagonalArquitecture.Application.Adapters.CreateOrder.Models;
using HexagonalArquitecture.Application.Ports.Driven;
using HexagonalArquitecture.Application.UseCases.CreateOrder;
using HexagonalArquitecture.Domain.Entities;

namespace HexagonalArquitecture.Application.Adapters.CreateOrder
{
    public class CreateOrderUseCase : ICreateOrderUseCase
    {
        private readonly IOrderRepository _orderRepository;

        public CreateOrderUseCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task ExecuteAsync(CreateOrderRequest request)
        {
            var items = new List<OrderItem>();

            foreach (var item in request.Items)
            {
                items.Add(new OrderItem 
                {
                    ProductName = item.ProductName,
                    Price = item.Price,
                    Quantity = item.Quantity 
                });
            }

            var order = new Order
            {
                Id = Guid.NewGuid(),
                CustomerId = request.CustomerId,
                Items = items
            };

            await _orderRepository.SaveOrderAsync(order);
        }
    }
}
