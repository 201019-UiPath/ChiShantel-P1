using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using SavvyDB.Models;
using Microsoft.AspNetCore.Http;
using SavvyLib;

namespace SavvyAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors()]

    public class ProductController : Controller
    {
        private readonly IProductTask producttask;

        public ProductController(IProductTask producttask)
        {
            this.producttask = producttask;
        }
        [HttpGet("GetAllProducts")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult GetAllProducts()
        {
            try 
            {
            return Ok(producttask.GetAllProducts());
            } 
            catch(Exception)
            {
                return StatusCode(500);
            } 
        }
        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                producttask.AddProduct(product);
                return CreatedAtAction("AddProduct", product);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
