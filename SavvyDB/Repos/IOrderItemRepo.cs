using SavvyDB.Models;
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