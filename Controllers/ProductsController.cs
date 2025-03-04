using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Models;

namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private static List<Product>? _product;

        public ProductsController()
        {
            _product = new List<Product>
            {
                new Product {ProductId = 1,ProductName="Iphone 14",Price=60000,IsActive=true},
                new Product {ProductId = 2,ProductName="Iphone 15",Price=70000,IsActive=true},
                new Product {ProductId = 3,ProductName="Iphone 16",Price=80000,IsActive=true},
                new Product {ProductId = 4,ProductName="Iphone 17",Price=90000,IsActive=true},
            };
            
        }
        

        [HttpGet]
        public IActionResult GetProducts()
        {
            if(_product == null)
            {
                return NotFound();
            }
            return Ok(_product);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var p = _product?.FirstOrDefault(p => p.ProductId==id);

            if (p==null)
            {
                return NotFound();
            }
            return Ok(p);
        }
    }
}