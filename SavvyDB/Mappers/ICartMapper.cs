using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface ICartMapper
    {
         SavvyDB.Entities.Cart ParseCart(SavvyDB.Models.Cart Cart);
         SavvyDB.Models.Cart ParseCart(SavvyDB.Entities.Cart Cart);
         ICollection<SavvyDB.Models.Cart> ParseCart(ICollection<SavvyDB.Entities.Cart> Cart);
         ICollection<SavvyDB.Entities.Cart> ParseCart(ICollection<SavvyDB.Models.Cart> Cart);
         List<SavvyDB.Entities.Cart> ParseCart(List<SavvyDB.Models.Cart> Cart);
         List<SavvyDB.Models.Cart> ParseCart(List<SavvyDB.Entities.Cart> Cart);
    }
}