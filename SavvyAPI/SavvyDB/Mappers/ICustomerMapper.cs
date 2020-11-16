using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface ICustomerMapper
    {
         Customer ParseCustomer(Customers Customer);
         Customers ParseCustomer (Customer Customer);
         ICollection<Customers> ParseCustomer(List<Customer> Customer);
         List<Customer> ParseCustomer(ICollection<Customers> Customer);
    }
}
