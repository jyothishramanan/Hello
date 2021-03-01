using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductWebApp.Models;
using ProductWebApp.Services;

namespace ProductWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _producService;
 
        public ProductController(ProductService productService)
        {
            _producService = productService;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
           return _producService.Get();
           
        }

        [HttpGet("{id:length(24)}", Name = "GetProduct")]
        public ActionResult<Product> Get(string id)
        {
            var prod = _producService.Get(id);

            if (prod == null)
            {
                return NotFound();
            }

            return prod;
        }
    }
}
