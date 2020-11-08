using System.Collections.Generic;
using SavvyDB.Models;
using System.Linq;
using SavvyDB.Entities;
using SavvyDB.Mappers;

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

        public SavvyDB.Models.Inventory GetProductsByLocation(int id)
        {
            return mapper.ParseInventory(
                context.Inventory
                .First(p => p.InventoryId == id));
        }
        public void AddCustomer(Customers Customer)
        {
            context.Customer.Add(mapper.ParseCustomer(Customer));
            context.SaveChanges();
        }
        public Customers GetCustomer(int id)
        {
            return mapper.ParseCustomer(
                context.Customer
                .First(p => p.Custid == id));
        }
        public List<Customers> GetAllCustomers(Customers Customer)
        {
            return mapper.ParseCustomer(
                context.Customer
                .ToList()
            );
        }
        public void AddCart(SavvyDB.Models.Cart Cart)
        {
            context.Cart.Add(mapper.ParseCart(Cart));
            context.SaveChanges();
        }

        public Models.Cart GetCart(int id)
        {
            return mapper.ParseCart(
                context.Cart
                .First(p => p.CartId == id));
        }

        public void UpdateCart(SavvyDB.Models.Cart Cart)
        {
            context.Cart.Update(mapper.ParseCart(Cart));
            context.SaveChanges();
        }

        public void DeleteCart(SavvyDB.Models.Cart Cart)
        {
            context.Cart.Remove(mapper.ParseCart(Cart));
            context.SaveChanges();
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
                .Where(p => p.LocationId == id)
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
        public List<SavvyDB.Models.Locations> GetAllLocations()
        {
            return mapper.ParseLocation(
                context.Location
                .ToList()
            );
        }

        public Locations GetLocation(int id)
        {
            return mapper.ParseLocation(context.Location
            .First(x => x.Locationid == id));
        }

        public void UpdateLocation(Locations Location)
        {
            context.Location.Update(mapper.ParseLocation(Location));
            context.SaveChanges();
        }

        public void DeleteLocation(Locations Location)
        {
            context.Location.Remove(mapper.ParseLocation(Location));
            context.SaveChanges();
        }

        public void AddManager(Managers Manager)
        {
            context.Manager.Add(mapper.ParseManager(Manager));
            context.SaveChanges();
        }

        public Managers GetManager(int id)
        {
            return mapper.ParseManager(
                context.Manager
                .First(p => p.Managerid == id));
        }
        public List<Managers> GetAllManagers()
        {
            return mapper.ParseManager(
                context.Manager
                .ToList()
            );
        }

        public void UpdateManager(Managers Manager)
        {
            context.Manager.Update(mapper.ParseManager(Manager));
            context.SaveChanges();
        }

        public void DeleteManager(Managers Manager)
        {
            context.Manager.Remove(mapper.ParseManager(Manager));
            context.SaveChanges();;
        }

        public void AddCartItem(Models.CartItem CartItem)
        {
            context.CartItem.Add(mapper.ParseCartItem(CartItem));
            context.SaveChanges();
        }

        public Models.CartItem GetCartItem(int id)
        {
            return mapper.ParseCartItem(
                context.CartItem
                .First(p => p.CartItemId == id));
        }

        public void UpdateCartItem(Models.CartItem CartItem)
        {
            context.CartItem.Update(mapper.ParseCartItem(CartItem));
            context.SaveChanges();
        }

        public void DeleteCartItem(Models.CartItem CartItem)
        {
            context.CartItem.Remove(mapper.ParseCartItem(CartItem));
            context.SaveChanges();
        }

        public void AddOrderItem(Models.OrderItem OrderItem)
        {
            context.OrderItem.Add(mapper.ParseOrderItem(OrderItem));
            context.SaveChanges();
        }

        public Models.OrderItem GetOrderItem(int id)
        {
            return mapper.ParseOrderItem(
                context.OrderItem
                .First(p => p.OrderItemId == id));
        }

        public void UpdateOrderItem(Models.OrderItem OrderItem)
        {
            context.OrderItem.Update(mapper.ParseOrderItem(OrderItem));
            context.SaveChanges();
        }

        public void DeleteOrderItem(Models.OrderItem OrderItem)
        {
            context.OrderItem.Remove(mapper.ParseOrderItem(OrderItem));
            context.SaveChanges();
        }

        public void AddOrder(Order Orders)
        {
            context.Orders.Add(mapper.ParseOrder(Orders));
            context.SaveChanges();
        }

        public Order GetOrder(int id)
        {
             return mapper.ParseOrder(
                    context.Orders
                    .First(c => c.Custid == id));

        }

        public void UpdateOrder(Order Orders)
        {
            context.Orders.Update(mapper.ParseOrder(Orders));
            context.SaveChanges();
        }

        public void DeleteOrder(Order Orders)
        {
            context.Orders.Remove(mapper.ParseOrder(Orders));
            context.SaveChanges();
        }

        public Models.Products GetProduct(int id)
        {
            return mapper.ParseProduct(
                context.Products
                .First(p => p.Productid == id)
            );
        }
        public List<Models.Products> GetAllProducts()
        {
            return mapper.ParseProduct(
                context.Products
                .ToList()
            );
        }
        public void AddProduct(SavvyDB.Models.Products Products)
        {
            context.Products.Add(mapper.ParseProduct(Products));
            context.SaveChanges();
        }
        public void UpdateProduct(Models.Products Products)
        {
            context.Products.Update(mapper.ParseProduct(Products));
            context.SaveChanges();
        }

        public void DeleteProduct(Models.Products Products)
        {
            context.Products.Remove(mapper.ParseProduct(Products));
            context.SaveChanges();
        }
    }
}
