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

        public void AddCustomer(Customer Customer)
        {
            repo.AddCustomer(Customer);
        }
        public void GetCustomer(int id)
        {
            repo.GetCustomer(id);
        }
        public void UpdateCustomer(Customer Customer)
        {
            repo.UpdateCustomer(Customer);
        }
        public void RemoveCustomer(Customer Customer)
        {
            repo.DeleteCustomer(Customer);
        }
    }
}