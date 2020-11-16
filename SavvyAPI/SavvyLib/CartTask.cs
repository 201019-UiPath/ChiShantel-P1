using SavvyDB;
using SavvyDB.Models;

namespace SavvyLib
{

    public class CartTask : ICartTask
    {
        private ICartRepo repo;
        public CartTask(ICartRepo repo)
        {
            this.repo = repo;
        }
        public void AddCart(Cart cart)
        {
            repo.AddCart(cart);
        }
        public void UpdateCart(Cart cart)
        {
            repo.UpdateCart(cart);
        }
        public Cart GetCart(int id)
        {
            return repo.GetCart(id);
        }
        public Cart GetCartByCustomer(int id)
        {
            return repo.GetCartByCustomer(id);
        }
        public void DeleteCart(Cart cart)
        {
            repo.DeleteCart(cart);
        }
    }
}