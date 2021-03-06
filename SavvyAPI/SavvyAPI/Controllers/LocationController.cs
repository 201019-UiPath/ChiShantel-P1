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

    public class LocationController : Controller
    {
        private readonly IProductTask producttask;
        private readonly ILocationTask locationtask;
        private readonly IInventoryTask inventorytask;

        public LocationController(IProductTask producttask, ILocationTask locationtask, IInventoryTask inventorytask)
        {
            this.producttask = producttask;
            this.locationtask = locationtask;
            this.inventorytask= inventorytask;
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
        [HttpGet("GetInventoryByLocation/{locationId}")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult GetInventoryByLocation(int id)
        {
            try
            {
                return Ok(inventorytask.GetInventoryByLocation(id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("GetAllLocations")]
        [Produces("application/json")]
        [EnableCors("_AllowSpecificOrigins")]
        public IActionResult GetAllLocations()
        {
            try 
            {
            return Ok(locationtask.GetAllLocations());
            } 
            catch(Exception)
            {
                return StatusCode(500);
            } 
        }
    }
}
