using SavvyDB;
using SavvyDB.Models;

namespace SavvyLib
{
    public class CustomerTask : ICustomerTask
    {
        private ICustomerRepo repo;
        public CustomerTask(ICustomerRepo repo)
        {
            this.repo = repo;
        }

        public void AddCustomer(Customer Customer)
        {
            repo.AddCustomer(Customer);
        }
        public Customer GetCustomer(int id)
        {
            return repo.GetCustomer(id);
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