using SavvyDB;
using SavvyDB.Models;
using System.Collections.Generic;

namespace SavvyLib
{
    public class OrderItemTask : IOrderItemTask
    {
        private IOrderItemRepo repo;

        public OrderItemTask(IOrderItemRepo repo)
        {
            this.repo = repo;
        }
        public List<OrderItem> GetAllOrderItems()
        {
            return repo.GetAllOrderItems();

        }
        public void AddOrderItem(OrderItem OrderItem)
        {
            repo.AddOrderItem(OrderItem);
        }
        public OrderItem GetOrderItem(int id)
        {
            return repo.GetOrderItem(id);
        }
        public void UpdateOrderItem(OrderItem OrderItem)
        {
            repo.UpdateOrderItem(OrderItem);
        }
        public void RemoveOrderItem(OrderItem OrderItem)
        {
            repo.DeleteOrderItem(OrderItem);
        }
    }
}