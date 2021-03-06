﻿using System;
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
    public class CartController : Controller
    {
        private readonly ICartItemTask cartitemtask;
        private readonly ICartTask carttask;
        public CartController(ICartItemTask cartitemtask, ICartTask carttask)
        {
            this.cartitemtask = cartitemtask;
            this.carttask = carttask;
        }
        
        [HttpGet("GetAllCartItems")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult GetAllCartItems()
        {
            try
            {
                return Ok(cartitemtask.GetAllCartItems(1));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        
        [HttpPost("AddCartItem")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult AddCartItem(CartItem cartitem)
        {
            try
            {
                cartitemtask.AddCartItem(cartitem);
                return CreatedAtAction("AddCartItem", cartitem);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("UpdateCartItem")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult UpdateCartItem(CartItem item)
        {
            try
            {
                cartitemtask.UpdateCartItem(item);
                return CreatedAtAction("UpdateCartItem", item);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("DeleteCartItem")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult DeleteCartItem(CartItem item)
        {
            try
            {
                cartitemtask.DeleteCartItem(item);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("AddCart")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult AddCart(Cart cart)
        {
            try
            {
                carttask.AddCart(cart);
                return CreatedAtAction("AddCart", cart);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("UpdateCart")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult UpdateCartItem(Cart cart)
        {
            try
            {
                carttask.UpdateCart(cart);
                return CreatedAtAction("UpdateCart", cart);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("DeleteCart")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult DeleteCart(Cart cart)
        {
            try
            {
                carttask.DeleteCart(cart);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
