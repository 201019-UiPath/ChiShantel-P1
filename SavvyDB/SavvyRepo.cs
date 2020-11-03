using System.Collections.Generic;
using System.Threading.Tasks;
using SavvyDB.Models;
using System.Linq;
using SavvyDB.Entities;
using Microsoft.EntityFrameworkCore;
namespace SavvyDB
{
    public class SavvyRepo : IRepo
    {
        private readonly SavvyContext context;
        private readonly IMapper mapper;

        public SavvyRepo(SavvyContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        //Add product to cart
       /* public void AddProduct(SavvyDB.Models.Products product)
        {
            context.Products.Add(mapper.ParseProduct(product));
            context.SaveChanges();
        }
        //Get list of products from a location
        //public List<Product> GetProducts()
        /*{
            return context.Product.Select(x => x)
            .ToList();
        }
        //Add quantity to inventory
        public void AddQuantity(int Product)
        {
            //throw new System.NotImplementedException;
        }
        //Select location
       // public Location SelectLocation()
        {
            //throw new System.NotImplementedException;
        }
        //Add quantity to cart
        public void AddQuantity(int Product)
        {
            //throw new System.NotImplementedException;
        }
        //Remove quantity selected from inventory
        public void RemoveQuantity(int Product)
        {
            //throw new System.NotImplementedException;
        }
        //Check order history
        //public List<Product> GetOrderHistory()
        {
            //throw new System.NotImplementedException;
        }
        //Get list of customers
        //public List<Customer> GetCustomers()
        {
            //throw new System.NotImplementedException;
        }
        //Get list of managers
        //public List<Manager> GetManagers()
        {
            //throw new System.NotImplementedException;
        } 
        */
        public void AddCustomer(Customers Customer)
        {
            context.Customer.Add(mapper.ParseCustomer(Customer));
            context.SaveChanges();
        }
    }
}
