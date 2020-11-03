using SavvyDB.Models;
using SavvyDB.SavvyRepo;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
namespace SavvyLib
{
    public class CustomerTask
    {
        public CustomerTask(ICustomerRepo repo)
        {
            this.repo = repo;
        }
         public void AddCustomer(Customer customer)
         {
            repo.AddCustomer(customer);
         }

    }
}