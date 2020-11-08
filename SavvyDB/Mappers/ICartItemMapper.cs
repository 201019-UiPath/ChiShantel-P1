using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface ICartItemMapper
    {
         CartItems ParseCartItem(CartItem CartItem);
         CartItem ParseCartItem(CartItems CartItem);
         ICollection<CartItems> ParseCartItem(List<CartItem> CartItem);
         List<CartItem> ParseCartItem(ICollection<CartItems> CartItem);
    }
}