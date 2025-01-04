using HexagonalArquitecture.Application.Adapters.CreateOrder.Models;
using HexagonalArquitecture.Application.Adapters.GetOrderById.Models;
using HexagonalArquitecture.Application.Ports.Drivers;
using HexagonalArquitecture.Application.UseCases.CreateOrder;
using HexagonalArquitecture.Application.UseCases.CreateOrder.Models;
using HexagonalArquitecture.Application.UseCases.GetOrderById;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalArquitecture.Presentation.Controllers
{
    // This controller is an adapter that implements the IOrderService interface.
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase, IOrderDriverPort
    {
        private readonly ICreateOrderUseCase _createOrder;
        private readonly IGetOrderByIdUseCase _getOrderById;

        public OrdersController(ICreateOrderUseCase createOrder, IGetOrderByIdUseCase getOrderById)
        {
            _createOrder = createOrder;
            _getOrderById = getOrderById;
        }

        [HttpPost]
        public async Task<CreateOrderResponse> CreateOrder(CreateOrderRequest createOrderRequest)
        {
            await _createOrder.ExecuteAsync(createOrderRequest);
            return new CreateOrderResponse();
        }

        [HttpGet("{id}")]
        public async Task<GetOrderByIdResponse?> GetOrderById(GetOrderByIdRequest getOrderByIdRequest)
        {
            var order = await _getOrderById.ExecuteAsync(getOrderByIdRequest);
            return order;
        }
    }
}
