using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB
{
    public interface ICartMapper
    {
         SavvyDB.Entities.Cart ParseCart(SavvyDB.Models.Cart Cart);

         SavvyDB.Models.Cart ParseCart(SavvyDB.Entities.Cart Cart);

         ICollection<SavvyDB.Models.Cart> ParseCart(List<SavvyDB.Entities.Cart> Cart);

         List<SavvyDB.Entities.Cart> ParseCart(ICollection<SavvyDB.Models.Cart> Cart);
    }
}