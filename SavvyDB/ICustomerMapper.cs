using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB
{
    public interface ICustomerMapper
    {
         Customer ParseCustomer(Customers Customer);

         ICollection<Customers> ParseCustomer(List<Customer> Customer);
         
         Customers ParseCustomer (Customer Customer);

         List<Customer> ParseCustomer(ICollection<Customers> Customer);
    }
}