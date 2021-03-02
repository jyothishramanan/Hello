using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductService.Services;
using Common.Models;
using Microsoft.AspNetCore.Cors;

namespace ProductWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[EnableCors("EnableCORS")]
    public class ProductController : ControllerBase
    {
        private readonly ProductServices _producService;
 
        public ProductController(ProductServices productService)
        {
            _producService = productService;
        }

        [HttpGet]
        //[EnableCors("EnableCORS")]
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
