using HexagonalArquitecture.Application.Adapters.GetOrderById.Models;

namespace HexagonalArquitecture.Application.UseCases.GetOrderById
{
    public interface IGetOrderByIdUseCase
    {
        Task<GetOrderByIdResponse?> ExecuteAsync(GetOrderByIdRequest request);
    }
}
