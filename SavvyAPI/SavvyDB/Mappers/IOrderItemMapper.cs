using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface IOrderItemMapper
    {
         OrderItems ParseOrderItem(OrderItem OrderItem);
         OrderItem ParseOrderItem(OrderItems OrderItem);
         ICollection<OrderItems> ParseOrderItem(List<OrderItem> OrderItem);
         List<OrderItem> ParseOrderItem(ICollection<OrderItems> OrderItem);
    }
}