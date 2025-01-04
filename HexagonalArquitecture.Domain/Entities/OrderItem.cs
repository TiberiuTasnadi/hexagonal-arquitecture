using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalArquitecture.Domain.Entities
{
    public class OrderItem
    {
        public required string ProductName { get; set; }
        public required decimal Price { get; set; }
        public required int Quantity { get; set; }
    }
}
