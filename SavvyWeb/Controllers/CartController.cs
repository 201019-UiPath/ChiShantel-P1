using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using SavvyWeb.Models;
using SavvyDB;
using SavvyDB.Models;

namespace SavvyWeb.Controllers
{
    public class CartController : Controller
    {
        private readonly IRepo _repo;
        private CartItem newcartitem = new CartItem();
        private int id;
        public CartController(IRepo repo)
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
        public ViewResult AddCartItem()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCartItem(CartItem cartitem)
        {
            if (ModelState.IsValid)
            {
                newcartitem.CartId = 1;
                newcartitem.ProductId = cartitem.ProductId;
                newcartitem.Quantity = cartitem.Quantity;
                _repo.AddCartItem(newcartitem);
                return Redirect("../Location/GetAllProducts");
            }
            else
                return View();
        }
    }
}
