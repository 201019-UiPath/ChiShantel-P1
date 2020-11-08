using SavvyDB;
using SavvyDB.Models;

namespace SavvyLib
{
    public class CartItemTask
    {
        private SavvyRepo repo;
        public CartItemTask(SavvyRepo repo)
        {
            this.repo = repo;
        }

        public void AddCartItem(CartItem cartitem) 
        {
            repo.AddCartItem(cartitem);
        }

        public CartItem GetCartItem(int id)
        {
            CartItem cartitem = repo.GetCartItem(id);
            return cartitem;
        }

        public void UpdateCartItem(CartItem cartitem)
        {
            repo.UpdateCartItem(cartitem);
        }

        public void DeleteCartItem(CartItem cartitem)
        {
            repo.DeleteCartItem(cartitem);
        }
    }
}