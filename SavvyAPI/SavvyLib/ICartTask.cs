using SavvyDB.Models;

namespace SavvyLib
{
    public interface ICartTask
    {
        void AddCart(Cart cart);
        void DeleteCart(Cart cart);
        Cart GetCart(int id);
        Cart GetCartByCustomer(int id);
        void UpdateCart(Cart cart);
    }
}