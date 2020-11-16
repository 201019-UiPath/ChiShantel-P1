using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using SavvyAPI.Models;
using SavvyDB;
using SavvyLib;
using SavvyDB.Models;
using Microsoft.AspNetCore.Cors;
using CartItem = SavvyDB.Models.CartItem;

namespace SavvyAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CartController : Controller
    {

        ICartItemTask _cartitemtask;
        IProductTask _locationtask;
        IInventoryTask _inventorytask;
        public CartController(ICartItemTask cartItemTask, IProductTask locationTask, IInventoryTask inventoryTask)
        {
            _cartitemtask = cartItemTask;
            _locationtask = locationTask;
            _inventorytask = inventoryTask;

        }
        [HttpGet("get/{id}")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult GetInventoryByLocation(int id)
        {
            try
            {
                return Ok(_inventorytask.GetInventoryByLocation(id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get")]
        [Produces("application/json")]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult GetAllCartItems()
        {
            try
            {
                return Ok(_cartitemtask.GetAllCartItems(1));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        
        [HttpPost("AddCartItem")]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult AddCartItem(CartItem cartitem)
        {
            try
            {
                _cartitemtask.AddCartItem(cartitem);
                return CreatedAtAction("AddCartItem", cartitem);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
