using SavvyDB.Models;
namespace SavvyDB.Repos

{
    public interface ICustomerRepo
    {
         void AddCustomer(Customers Customer);
         Customers GetCustomer(int id);
         void UpdateCustomer(Customers Customer);
         void DeleteCustomer (Customers Customer);
    }
}