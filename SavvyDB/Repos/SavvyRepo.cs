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
       public void AddProduct(SavvyDB.Models.Products product)
        {
            context.Products.Add(mapper.ParseProduct(product));
            context.SaveChanges();
        }
        //Get list of products from a location
        /*public List<SavvyDB.Models.Inventory> GetProducts(int id)
        {
            return mapper.ParseInventory(
                context.Inventory
                .Include("Name")
                .Where(x => x.Locationid == id)
                .ToList()
                
            );
        }
        */
        public List<SavvyDB.Entities.Inventory> GetProducts(int id)
        {
            return context.Inventory
            //.Include("Inventory.Quantity")
            .Where (x => x.Locationid == id)
            .ToList();
        
        }
        //Add quantity to inventory
        /*public void AddQuantity(Inventory inventory)
        {
            context.Inventory.Add(inventory);
            context.SaveChanges();
        }*/
        //Select location
        public List<SavvyDB.Entities.Location> GetLocations()
        {
            return context.Location.Select(x => x)
            .ToList();
        }
        
        //Add quantity to cart
        public void AddToCart(SavvyDB.Models.Cart cart)
        {
            context.Cart.Add(mapper.ParseCart(cart));
            context.SaveChanges();
        }
            
        //Remove quantity selected from inventory
        /*public void RemoveQuantity(int Product)
        {
            throw new System.NotImplementedException;
        } */
        //Check order history
        public List<SavvyDB.Entities.Cart> GetOrderHistory()
        {
            return context.Cart
            .ToList();
        }/*
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
