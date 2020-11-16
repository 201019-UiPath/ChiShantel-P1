using SavvyDB.Models;
using System.Collections.Generic;
using System;
namespace SavvyDB

{
    public interface IOrderItemRepo
    {
        void AddOrderItem(OrderItem OrderItem);
        OrderItem GetOrderItem(int id);
        List<OrderItem> GetAllOrderItems();
        void UpdateOrderItem(OrderItem OrderItem);
        void DeleteOrderItem(OrderItem OrderItem);
    }
}