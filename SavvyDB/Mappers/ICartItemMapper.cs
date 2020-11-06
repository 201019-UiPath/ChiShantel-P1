using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface ICartItemItemMapper
    {
         SavvyDB.Entities.CartItem ParseCartItem(SavvyDB.Models.CartItem CartItem);
         SavvyDB.Models.CartItem ParseCartItem(SavvyDB.Entities.CartItem CartItem);
         ICollection<SavvyDB.Models.CartItem> ParseCartItem(ICollection<SavvyDB.Entities.CartItem> CartItem);
         ICollection<SavvyDB.Entities.CartItem> ParseCartItem(ICollection<SavvyDB.Models.CartItem> CartItem);
         List<SavvyDB.Entities.CartItem> ParseCartItem(List<SavvyDB.Models.CartItem> CartItem);
         List<SavvyDB.Models.CartItem> ParseCartItem(List<SavvyDB.Entities.CartItem> CartItem);
    }
}