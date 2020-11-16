using SavvyDB;
using SavvyDB.Models;
using System.Collections.Generic;
using System;

namespace SavvyLib
{
    public class OrderTask
    {
        private IRepo repo;

        public OrderTask(IRepo repo)
        {
            this.repo = repo;
        }
        public void AddOrder(Order Order)
        {
            repo.AddOrder(Order);
        }
        public Order GetOrder(int id)
        {
           return repo.GetOrder(id);
        }
        public List<Order> GetAllOrders()
        {
            return repo.GetAllOrders();
        }
        public Order GetOrderByDate(DateTime date)
        {
            return repo.GetOrderByDate(date);
        }
        public List<Order> GetOrderFirst(DateTime date)
        {
            return repo.GetOrderFirst(date);
        }
        public List<Order> GetOrderLast(DateTime date)
        {
            return repo.GetOrderLast(date);
        }
        public List<Order> GetOrderCheap(Customer Customer)
        {
            return repo.GetOrderCheap(Customer);
        }
        public List<Order> GetOrderExpensive(Customer Customer)
        {
            return repo.GetOrderExpensive(Customer);
        }
        public void UpdateOrder(Order Order)
        {
            repo.UpdateOrder(Order);
        }
        public void RemoveOrder(Order Order)
        {
            repo.DeleteOrder(Order);
        }
    }
}