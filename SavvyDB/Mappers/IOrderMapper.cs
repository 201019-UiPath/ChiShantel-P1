using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface IOrderMapper
    {
         Orders ParseOrder(Order Order);
         Order ParseOrder(Orders Order);
         ICollection<Order> ParseOrder(ICollection<Orders> Order);
         ICollection<Orders> ParseOrder(ICollection<Order> Order);
         List<Order> ParseOrder(List<Orders> Order);
         List<Orders> ParseOrder(List<Order> Order);
    }
}