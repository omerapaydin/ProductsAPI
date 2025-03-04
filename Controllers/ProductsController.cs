using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private static readonly string[] Products = {
            "Iphone 14", "Iphone 15", "Iphone 16"
        };
        

        [HttpGet]
        public string[] GetProducts()
        {
            return Products;
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return Products[id];
        }
    }
}