using SavvyDB;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyLib
{
    public class CartItemTask : ICartItemTask
    {
        SavvyRepo _repo;
        public CartItemTask(SavvyRepo repo)
        {
            _repo = repo;
        }

        public void AddCartItem(CartItem cartitem) 
        {
            _repo.AddCartItem(cartitem);
        }

        public CartItem GetCartItem(int id)
        {
            CartItem cartitem = _repo.GetCartItem(id);
            return cartitem;
        }
        public List<CartItem> GetAllCartItems(int id)
        {
            List<CartItem> cartitem = _repo.GetAllCartItems(id);
            return cartitem;
        }

        public void UpdateCartItem(CartItem cartitem)
        {
            _repo.UpdateCartItem(cartitem);
        }

        public void DeleteCartItem(CartItem cartitem)
        {
            _repo.DeleteCartItem(cartitem);
        }
    }
}