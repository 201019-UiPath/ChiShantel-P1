using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface ICartItemMapper
    {
         SavvyDB.Entities.CartItem ParseCartItem(SavvyDB.Models.CartItem CartItem);
         SavvyDB.Models.CartItem ParseCartItem(SavvyDB.Entities.CartItem CartItem);
         ICollection<SavvyDB.Entities.CartItem> ParseCartItem(List<SavvyDB.Models.CartItem> CartItem);
         List<SavvyDB.Models.CartItem> ParseCartItem(ICollection<SavvyDB.Entities.CartItem> CartItem);
    }
}