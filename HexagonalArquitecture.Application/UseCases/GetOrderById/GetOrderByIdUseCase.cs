using HexagonalArquitecture.Application.Adapters.GetOrderById.Models;
using HexagonalArquitecture.Application.Models;
using HexagonalArquitecture.Application.Ports.Driven;
using HexagonalArquitecture.Application.UseCases.GetOrderById;

namespace HexagonalArquitecture.Application.Adapters.GetOrderById
{
    public class GetOrderByIdUseCase : IGetOrderByIdUseCase
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrderByIdUseCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<GetOrderByIdResponse?> ExecuteAsync(GetOrderByIdRequest request)
        {
            var order = await _orderRepository.GetOrderByIdAsync(request.OrderId);

            if (order is null)
            {
                throw new Exception("Not found.");
            }

            return new GetOrderByIdResponse
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                Items = order.Items.Select(i =>
                {
                    return new OrderItemDto
                    {
                        ProductName = i.ProductName,
                        Price = i.Price,
                        Quantity = i.Quantity
                    };
                }).ToList()
            };
        }
    }
}
