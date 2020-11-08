using SavvyDB.Models;
namespace SavvyDB.Repos

{
    public interface IOrderRepo
    {
        void AddOrder(Order Orders);
        Order GetOrder(int id);
        void UpdateOrder(Order Orders);
        void DeleteOrder(Order Orders);
    }
}