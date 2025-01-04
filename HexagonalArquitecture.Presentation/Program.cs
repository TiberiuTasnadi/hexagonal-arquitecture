using HexagonalArquitecture.Application.Adapters.CreateOrder;
using HexagonalArquitecture.Application.Adapters.GetOrderById;
using HexagonalArquitecture.Application.Ports.Driven;
using HexagonalArquitecture.Application.UseCases.CreateOrder;
using HexagonalArquitecture.Application.UseCases.GetOrderById;
using HexagonalArquitecture.Infrastructure.Repositories;

namespace HexagonalArquitecture.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IOrderRepository, OrderRepository>();

            builder.Services.AddTransient<ICreateOrderUseCase, CreateOrderUseCase>();
            builder.Services.AddTransient<IGetOrderByIdUseCase, GetOrderByIdUseCase>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
