using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyLib
{
    public interface ICartItemTask
    {
        public void AddCartItem(CartItem cartitem); 
        public CartItem GetCartItem(int id);
        public List<CartItem> GetAllCartItems(int id);

        public void UpdateCartItem(CartItem cartitem);

        public void DeleteCartItem(CartItem cartitem);

    }
}