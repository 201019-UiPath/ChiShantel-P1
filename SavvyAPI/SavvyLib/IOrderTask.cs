using SavvyDB.Models;
using System;
using System.Collections.Generic;

namespace SavvyLib
{
    public interface IOrderTask
    {
        void AddOrder(Order Order);
        List<Order> GetAllOrders();
        Order GetOrder(int id);
        Order GetOrderByDate(DateTime date);
        List<Order> GetOrderCheap(Customer Customer);
        List<Order> GetOrderExpensive(Customer Customer);
        List<Order> GetOrderFirst(DateTime date);
        List<Order> GetOrderLast(DateTime date);
        void RemoveOrder(Order Order);
        void UpdateOrder(Order Order);
    }
}