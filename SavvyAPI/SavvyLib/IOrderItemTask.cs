using SavvyDB.Models;
using System.Collections.Generic;

namespace SavvyLib
{
    public interface IOrderItemTask
    {
        void AddOrderItem(OrderItem OrderItem);
        List<OrderItem> GetAllOrderItems();
        OrderItem GetOrderItem(int id);
        void RemoveOrderItem(OrderItem OrderItem);
        void UpdateOrderItem(OrderItem OrderItem);
    }
}