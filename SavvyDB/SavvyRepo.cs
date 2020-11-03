using System.Collections.Generic;
using System.Threading.Tasks;
using HerosDB.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace SavvyDB
{
    public class SavvyRepo : IRepo
    {
        //Add product to cart
        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        //Get list of products from a location
        public List<Product> GetProducts()
        {
            throw new System.NotImplementedException;
        }
        //Add quantity to inventory
        public void AddQuantity(int Product)
        {
            throw new System.NotImplementedException;
        }
        //Select location
        public Location SelectLocation()
        {
            throw new System.NotImplementedException;
        }
        //Add quantity to cart
        public void AddQuantity(int Product)
        {
            throw new System.NotImplementedException;
        }
        //Remove quantity selected from inventory
        public void RemoveQuantity(int Product)
        {
            throw new System.NotImplementedException;
        }
        //Check order history
        public List<Product> GetOrderHistory()
        {
            throw new System.NotImplementedException;
        }
        //Get list of customers
        public List<Customer> GetCustomers()
        {
            throw new System.NotImplementedException;
        }
        //Get list of managers
        public List<Manager> GetManagers()
        {
            throw new System.NotImplementedException;
        }
    }
}
