using HexagonalArquitecture.Application.Models;
using HexagonalArquitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalArquitecture.Application.Adapters.GetOrderById.Models
{
    public class GetOrderByIdResponse
    {
        public required Guid Id { get; set; }
        public required Guid CustomerId { get; set; }
        public List<OrderItemDto> Items { get; set; } = new();
    }
}
