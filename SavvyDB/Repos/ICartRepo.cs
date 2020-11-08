using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface ICartRepo
    {
        void AddCart(Cart Cart);
        void UpdateCart(Cart Cart);
        Cart GetCart(int id);
        void DeleteCart(Cart Cart);
    }
}