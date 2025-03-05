using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.DTO
{
    public class ProductDTO
    {
         public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
    }
}