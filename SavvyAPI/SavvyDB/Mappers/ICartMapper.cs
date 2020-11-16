using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface ICartMapper
    {
         Carts ParseCart(Cart Cart);
         Cart ParseCart(Carts Cart);
         ICollection<Carts> ParseCart(List<Cart> Cart);
         List<Cart> ParseCart(ICollection<Carts> Cart);
    }
}