using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB
{
    public interface ICartMapper
    {
         Cart ParseCart(Cart Cart);

         ICollection<Cart> ParseCart(List<Cart> Cart);

         List<Cart> ParseCart(ICollection<Cart> Cart);
    }
}