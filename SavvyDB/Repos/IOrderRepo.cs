using SavvyDB.Models;
using System.Collections.Generic;
using System;
namespace SavvyDB.Repos

{
    public interface IOrderRepo
    {
        void AddOrder(Order Orders);
        Order GetOrder(int id);
        Order GetOrderByDate(DateTime date);
        List<Order> GetOrderExpensive(Customer Customer);
        List<Order> GetOrderCheap(Customer Customer);
        List<Order> GetOrderFirst(DateTime date);
        List<Order> GetOrderLast(DateTime date);
        void UpdateOrder(Order Orders);
        void DeleteOrder(Order Orders);
    }
}