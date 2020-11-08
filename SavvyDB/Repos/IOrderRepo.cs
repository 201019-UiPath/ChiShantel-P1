using SavvyDB.Models;
using System.Collections.Generic;
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