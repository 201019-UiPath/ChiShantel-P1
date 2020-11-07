using System.Collections.Generic;
using SavvyDB.Models;
using System.Linq;
using SavvyDB.Entities;
using SavvyDB.Mappers;
using Microsoft.EntityFrameworkCore;
using SavvyDB.Repos;

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
        public List<SavvyDB.Models.Inventory> GetProductsByLocation(int id)
        {
            return mapper.ParseInventory(
                context.Inventory
                .Include("Name")
                .Where(x => x.LocationId == id)
                .ToList()
            );
        }

        
        //Add quantity to cart
        public void AddToCart(SavvyDB.Models.Cart cart)
        {
            context.Cart.Add(mapper.ParseCart(cart));
            context.SaveChanges();
        }
            
        /*
        public List<SavvyDB.Entities.Cart> GetOrderHistory()
        {
            return context.OrderItem
            .ToList();
        }*/
        public void AddCustomer(Customers Customer)
        {
            context.Customer.Add(mapper.ParseCustomer(Customer));
            context.SaveChanges();
        }

        public void AddCart(SavvyDB.Models.Cart Cart)
        {
            context.Cart.Add(mapper.ParseCart(Cart));
            context.SaveChanges();
        }

        public void UpdateCart(SavvyDB.Models.Cart Cart)
        {
            context.Cart.Update(mapper.ParseCart(Cart));
            context.SaveChanges();
        }
        /*public SavvyDB.Models.Cart GetCart(int id)
        {
            return context.Cart.Select(id => id)
            .ToList();
        }*/

        public void DeleteCart(SavvyDB.Models.Cart Cart)
        {
            context.Cart.Remove(mapper.ParseCart(Cart));
            context.SaveChanges();
        }

        public Customer GetCustomer(int id)
        {
            return (Customer) context.Customer.Single(x => x.Custid == id); 
        }

        public void UpdateCustomer(Customers Customer)
        {
            context.Customer.Update(mapper.ParseCustomer(Customer));
            context.SaveChanges();
        }

        public void DeleteCustomer(Customers Customer)
        {
            context.Customer.Remove(mapper.ParseCustomer(Customer));
            context.SaveChanges();
        }

        public void AddInventory(SavvyDB.Models.Inventory Inventory)
        {
            context.Inventory.Add(mapper.ParseInventory(Inventory));
            context.SaveChanges();
        }

        public List<SavvyDB.Models.Inventory> GetInventory(int id)
        {
            return mapper.ParseInventory(
                    context.Inventory
                    .Where(x => x.LocationId == id)
                    .ToList());
        }

        public void UpdateInventory(SavvyDB.Models.Inventory Inventory)
        {
            context.Inventory.Update(mapper.ParseInventory(Inventory));
            context.SaveChanges();            
        }

        public void DeleteInventory(SavvyDB.Models.Inventory Inventory)
        {
            context.Inventory.Remove(mapper.ParseInventory(Inventory));
            context.SaveChanges();
        }

        public void AddLocation(Locations Location)
        {
            context.Location.Add(mapper.ParseLocation(Location));
            context.SaveChanges();
        }
        //Select location
        public List<SavvyDB.Models.Locations> GetLocations()
        {
            return mapper.ParseLocation(context.Location.Select(x => x))
            .ToList();
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

        public Models.Cart GetCart(int id)
        {
            throw new System.NotImplementedException();
        }

        Customers ICustomerRepo.GetCustomer(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
