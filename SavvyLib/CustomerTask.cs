using SavvyDB;
using SavvyDB.Models;

namespace SavvyLib
{
    public class CustomerTask
    {
        private SavvyRepo repo;
        public CustomerTask(SavvyRepo repo)
        {
            this.repo = repo;
        }

        public void AddCustomer(Customers Customer)
        {
            repo.AddCustomer(Customer);
        }
        public void GetCustomer(int id)
        {
            repo.GetCustomer(id);
        }
        public void UpdateCustomer(Customers Customer)
        {
            repo.UpdateCustomer(Customer);
        }
        public void RemoveCustomer(Customers Customer)
        {
            repo.DeleteCustomer(Customer);
        }
    }
}