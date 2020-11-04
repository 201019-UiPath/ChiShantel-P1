using SavvyDB;
using System.Collections.Generic;
using SavvyDB.Models;
using System;

namespace SavvyLib
{
    public class CustomerTask
    {
        private ICustomerRepo repo;
        public CustomerTask(ICustomerRepo repo)
        {
            this.repo = repo;
        }
        private IQueryable<Customer> GetCustomerById(int id) =>
    from o in _context.Customers.AsNoTracking()
    where o.Id == id
    select o;

    public async Task<Customer> GetById(int id)
        {
            Customer customer = await (
            from o in GetCustomerById(id)
            select new Customer
        {
            CustId = o.Id,
        })
        .FirstOrDefaultAsync();

    return Customer;
        }
        /*public void AddCustomer(Customers customer)
         {
            repo.AddCustomer(customer);
         } */
        
       
    }
}