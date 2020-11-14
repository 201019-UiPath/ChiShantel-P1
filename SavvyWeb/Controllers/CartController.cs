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
using SavvyDB.Models;
using Microsoft.AspNetCore.Cors;
using CartItem = SavvyDB.Models.CartItem;

namespace SavvyAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CartController : Controller
    {
        
        private readonly IRepo _repo;
        private CartItem newcartitem = new CartItem();
        private int id;
        public CartController(IRepo repo)
        {
            _repo = repo;

        }
        [HttpGet("get/{id}")]
        [Produces("application/json")]
        public IActionResult GetInventoryByLocation(int id)
        {
            var Inventory = _repo.GetInventoryByLocation(id);
            return View(Inventory);
        }
        public ViewResult AddCartItem()
        {
            return View();
        }
        [HttpGet("get")]
        [Produces("application/json")]
        public IActionResult GetAllCartItems()
        {
            var cartitems = _repo.GetAllCartItems(1);
            return View(cartitems);
        }
        /*public IActionResult DeleteCartItem(CartItem cartItem)
        {
            var cartitem = _repo.DeleteCartItem(cartItem);
            return View();
        }
        */
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
