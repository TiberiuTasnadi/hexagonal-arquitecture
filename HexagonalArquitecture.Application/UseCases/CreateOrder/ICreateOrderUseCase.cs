using HexagonalArquitecture.Application.Adapters.CreateOrder.Models;

namespace HexagonalArquitecture.Application.UseCases.CreateOrder
{
    public interface ICreateOrderUseCase
    {
        Task ExecuteAsync(CreateOrderRequest request);
    }
}
