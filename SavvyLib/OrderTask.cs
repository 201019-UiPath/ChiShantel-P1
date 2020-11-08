using SavvyDB;
using SavvyDB.Models;

namespace SavvyLib
{
    public class OrderTask
    {
        private SavvyRepo repo;

        public OrderTask(SavvyRepo repo)
        {
            this.repo = repo;
        }
        public void AddOrder(Order Order)
        {
            repo.AddOrder(Order);
        }
        public void GetOrder(int id)
        {
            repo.GetOrder(id);
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