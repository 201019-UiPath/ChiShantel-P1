using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface ICustomerRepo
    {
         void AddCustomer(Customers Customer);
         Customers GetCustomer(int id);
         List<Customers> GetAllCustomers();
         void UpdateCustomer(Customers Customer);
         void DeleteCustomer (Customers Customer);
    }
}