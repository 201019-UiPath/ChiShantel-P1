using SavvyDB.Models;
using System.Collections.Generic;
using System;
namespace SavvyDB.Repos

{
    public interface IOrderItemRepo
    {
        void AddOrderItem(OrderItem OrderItem);
        OrderItem GetOrderItem(int id);
        List<OrderItem> GetAllOrderItems();
        List<OrderItem> GetOrderItemsExpensive(double num);
        List<OrderItem> GetOrderItemsCheap(double num);
        List<OrderItem> GetOrderItemDateEarly(DateTime date);
        List<OrderItem> GetOrderItemDateLate(DateTime date);
        void UpdateOrderItem(OrderItem OrderItem);
        void DeleteOrderItem(OrderItem OrderItem);
    }
}