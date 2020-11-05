using SavvyDB.Models;
namespace SavvyDB
{
    public interface ICustomerRepo
    {
         void AddCustomer(Customers Customer);
    }
}