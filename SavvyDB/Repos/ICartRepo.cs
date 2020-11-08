using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface ICartRepo
    {
        void AddCart(Cart Cart);
        void UpdateCart(Cart Cart);
        Cart GetCart(int id);
        Cart GetCartByCustomer(int id);
        List<Cart> GetAllCarts();
        void DeleteCart(Cart Cart);
    }
}