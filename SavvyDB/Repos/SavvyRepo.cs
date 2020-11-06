using System.Collections.Generic;
using SavvyDB.Models;
using System.Linq;
using SavvyDB.Entities;
using SavvyDB.Mappers;
using Microsoft.EntityFrameworkCore;
namespace SavvyDB
{
    public class SavvyRepo : IRepo
    {
        private SavvyContext context;
        private IMapper mapper;

        public SavvyRepo(SavvyContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

       public void AddProduct(SavvyDB.Models.Products product)
        {
            context.Products.Add(mapper.ParseProduct(product));
            context.SaveChanges();
        }
       /* public List<SavvyDB.Entities.Products> GetProducts()
        {

        }

        public void UpdateProducts(SavvyDB.Entities.Products Products)
        {

        }
        
        public 
        */
        //Get list of products from a location
        public List<SavvyDB.Models.Inventory> GetProductsByLocation(int id)
        {
            return mapper.ParseInventory(
                context.Inventory
                .Include("Name")
                .Where(x => x.LocationId == id)
                .ToList()
            );
        }
        //Add quantity to inventory
        public void AddQuantity(SavvyDB.Entities.Inventory inventory)
        {
            context.Inventory.Add(inventory);
            context.SaveChanges();
        }
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

        public void AddCart(SavvyDB.Models.Cart Cart)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCart(SavvyDB.Models.Cart Cart)
        {
            throw new System.NotImplementedException();
        }

        public SavvyDB.Models.Cart GetCart(int id)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCart(SavvyDB.Models.Cart Cart)
        {
            throw new System.NotImplementedException();
        }

        public Customers GetCustomer(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCustomer(Customers Customer)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCustomer(Customers Customer)
        {
            throw new System.NotImplementedException();
        }

        public void AddInventory(SavvyDB.Models.Inventory Inventory)
        {
            throw new System.NotImplementedException();
        }

        public List<SavvyDB.Models.Inventory> GetInventory(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateInventory(SavvyDB.Models.Inventory Inventory)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteInventory(SavvyDB.Models.Inventory Inventory)
        {
            throw new System.NotImplementedException();
        }

        public void AddLocation(Locations Location)
        {
            throw new System.NotImplementedException();
        }

        public Locations GetLocation(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateLocation(Locations Location)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteLocation(Locations Location)
        {
            throw new System.NotImplementedException();
        }

        public void AddManager(Managers Manager)
        {
            throw new System.NotImplementedException();
        }

        public Managers GetManager(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateManager(Managers Manager)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteManager(Managers Manager)
        {
            throw new System.NotImplementedException();
        }

        public void AddCartItem(Models.CartItem CartItem)
        {
            throw new System.NotImplementedException();
        }

        public Models.CartItem GetCartItem(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCartItem(Models.CartItem CartItem)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCartItem(Models.CartItem CartItem)
        {
            throw new System.NotImplementedException();
        }

        public void AddOrderItem(Models.OrderItem OrderItem)
        {
            throw new System.NotImplementedException();
        }

        public Models.OrderItem GetOrderItem(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateOrderItem(Models.OrderItem OrderItem)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteOrderItem(Models.OrderItem OrderItem)
        {
            throw new System.NotImplementedException();
        }

        public void AddOrder(Order Orders)
        {
            throw new System.NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateOrder(Order Orders)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteOrder(Order Orders)
        {
            throw new System.NotImplementedException();
        }

        public List<Models.Products> GetProduct(Models.Products Products)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct(Models.Products Products)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProduct(Models.Products Products)
        {
            throw new System.NotImplementedException();
        }
    }
}
