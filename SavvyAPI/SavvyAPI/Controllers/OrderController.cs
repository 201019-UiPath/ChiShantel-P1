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
    public class OrderController : Controller
    {
        private readonly IOrderItemTask orderitemtask;
        private readonly IOrderTask ordertask;
        public OrderController(IOrderItemTask orderitemtask, IOrderTask ordertask)
        {
            this.orderitemtask = orderitemtask;
            this.ordertask = ordertask;
        }
        
        [HttpGet("GetAllOrderItems")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult GetAllOrderItems()
        {
            try
            {
                return Ok(orderitemtask.GetAllOrderItems());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        
        [HttpPost("AddOrderItem")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult AddOrderItem(OrderItem orderitem)
        {
            try
            {
                orderitemtask.AddOrderItem(orderitem);
                return CreatedAtAction("AddOrderItem", orderitem);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("UpdateOrderItem")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult UpdateOrderItem(OrderItem orderitem)
        {
            try
            {
                orderitemtask.UpdateOrderItem(orderitem);
                return CreatedAtAction("UpdateOrderItem", orderitem);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("DeleteOrderItem")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult DeleteOrderItem(OrderItem orderitem)
        {
            try
            {
                orderitemtask.RemoveOrderItem(orderitem);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("AddOrder")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult AddOrder(Order order)
        {
            try
            {
                ordertask.AddOrder(order);
                return CreatedAtAction("AddOrder", order);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("UpdateOrder")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult UpdateOrderItem(Order order)
        {
            try
            {
                ordertask.UpdateOrder(order);
                return CreatedAtAction("UpdateOrder", order);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("DeleteOrder")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult DeleteOrder(Order order)
        {
            try
            {
                ordertask.RemoveOrder(order);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
