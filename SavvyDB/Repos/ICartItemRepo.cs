using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface ICartItemRepo
    {
        void AddCartItem(CartItem CartItem);
        CartItem GetCartItem(int id);
        void UpdateCartItem(CartItem CartItem);
        void DeleteCartItem(CartItem CartItem);
    }
}