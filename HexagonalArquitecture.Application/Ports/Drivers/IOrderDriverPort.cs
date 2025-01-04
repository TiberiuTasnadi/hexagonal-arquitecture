using HexagonalArquitecture.Application.Adapters.CreateOrder.Models;
using HexagonalArquitecture.Application.Adapters.GetOrderById.Models;
using HexagonalArquitecture.Application.UseCases.CreateOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalArquitecture.Application.Ports.Drivers
{
    public interface IOrderDriverPort
    {
        Task<CreateOrderResponse> CreateOrder(CreateOrderRequest createOrderRequest);
        Task<GetOrderByIdResponse?> GetOrderById(GetOrderByIdRequest getOrderByIdRequest);
    }
}
