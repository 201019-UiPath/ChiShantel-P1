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
        [EnableCors("_myAllowSpecificOrigins")]
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
        public ViewResult AddCartItem()
        {
            return View();
        }
        [HttpGet("get")]
        [Produces("application/json")]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult GetAllCartItems()
        {
            var cartitems = _cartitemtask.GetAllCartItems(1);
            return View(cartitems);
        }
        [HttpDelete("DeleteHouse")]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult DeleteCartItem(CartItem cartitem)
        {
            _cartitemtask.DeleteCartItem(cartitem);
            return View();
        }
        
        [HttpPost]
        public IActionResult AddCartItem(CartItem cartitem)
        {
            _cartitemtask.AddCartItem(cartitem);
            return CreatedAtAction("AddCartItem", cartitem);
        }
    }
}
