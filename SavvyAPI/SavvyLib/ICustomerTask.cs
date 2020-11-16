using SavvyDB.Models;
namespace SavvyLib
{
    public interface ICustomerTask
    {
        public void AddCustomer(Customer Customer);

        public Customer GetCustomer(int id);

        public void UpdateCustomer(Customer Customer);

        public void RemoveCustomer(Customer Customer);
    }
}