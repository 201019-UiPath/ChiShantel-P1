using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface IOrderMapper
    {
         Orders ParseOrder(Order Order);
         Order ParseOrder(Orders Order);
         ICollection<Orders> ParseOrder(List<Order> Order);
         List<Order> ParseOrder(ICollection<Orders> Order);
    }
}