using SavvyDB;
using SavvyDB.Models;

namespace SavvyLib
{
    public class OrderItemTask
    {
        private IOrderItemRepo repo;

        public OrderItemTask(IOrderItemRepo repo)
        {
            this.repo = repo;
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