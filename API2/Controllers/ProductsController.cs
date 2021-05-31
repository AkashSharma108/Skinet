using Infrastructure.Data;
using Core.Entitities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public  ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts() {
            return _context.Products.ToList();    
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "this will return single product";
       
        }

    }
}
