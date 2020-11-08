using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface IOrderItemRepo
    {
        void AddOrderItem(OrderItem OrderItem);
        OrderItem GetOrderItem(int id);
        void UpdateOrderItem(OrderItem OrderItem);
        void DeleteOrderItem(OrderItem OrderItem);
    }
}