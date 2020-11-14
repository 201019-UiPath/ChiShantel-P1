using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SavvyDB;

namespace SavvyWeb
{
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
        public IActionResult GetInventoryByLocation(int id)
        {
            var Inventory = _repo.GetInventoryByLocation(id);
            return View(Inventory);
        }
    }
}
