using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SavvyDB;

namespace SavvyAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LocationController : Controller
    {

        private readonly IRepo _repo;
        private int id;
        public LocationController(IRepo repo)
        {
            _repo = repo;
            
        }
        public IActionResult GetAllProducts()
        {
            var Product = _repo.GetAllProducts();
            return View(Product);
        }
        
    }
}
