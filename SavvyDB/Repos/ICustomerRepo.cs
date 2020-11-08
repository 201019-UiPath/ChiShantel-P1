using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface ICustomerRepo
    {
         void AddCustomer(Customer Customer);
         Customer GetCustomer(int id);
         List<Customer> GetAllCustomers();
         void UpdateCustomer(Customer Customer);
         void DeleteCustomer (Customer Customer);
    }
}