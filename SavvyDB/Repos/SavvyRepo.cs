using System.Collections.Generic;
using System;
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

        public Inventory GetProductsByLocation(int id)
        {
            return mapper.ParseInventory(
                context.Inventories
                .First(p => p.Inventoryid == id));
        }
        public void AddCustomer(Customer Customer)
        {
            context.Customers.Add(mapper.ParseCustomer(Customer));
            context.SaveChanges();
        }
        public Customer GetCustomer(int id)
        {
            return mapper.ParseCustomer(
                context.Customers
                .First(x => x.Customerid == id));
        }
        public List<Customer> GetAllCustomers()
        {
            return mapper.ParseCustomer(
                context.Customers
                .ToList()
            );
        }
                public void UpdateCustomer(Customer Customer)
        {
            context.Customers.Update(mapper.ParseCustomer(Customer));
            context.SaveChanges();
        }

        public void DeleteCustomer(Customer Customer)
        {
            context.Customers.Remove(mapper.ParseCustomer(Customer));
            context.SaveChanges();
        }
        public void AddCart(Cart Cart)
        {
            context.Carts.Add(mapper.ParseCart(Cart));
            context.SaveChanges();
        }

        public Cart GetCart(int id)
        {
            return mapper.ParseCart(
                context.Carts
                .First(x => x.Cartid == id));
        }
        public Cart GetCartByCustomer(int id)
        {
            return mapper.ParseCart(
                context.Carts
                .First(x => x.Customerid == id));
        }
        public List<Cart> GetAllCarts()
        {
            return mapper.ParseCart(
                context.Carts
                .ToList()
            );
        }
        public void UpdateCart(Cart Cart)
        {
            context.Carts.Update(mapper.ParseCart(Cart));
            context.SaveChanges();
        }

        public void DeleteCart(Cart Cart)
        {
            context.Carts.Remove(mapper.ParseCart(Cart));
            context.SaveChanges();
        }

        public void AddInventory(Inventory Inventory)
        {
            context.Inventories.Add(mapper.ParseInventory(Inventory));
            context.SaveChanges();
        }

        public List<Inventory> GetInventory(int id)
        {
            return mapper.ParseInventory(
                context.Inventories
                .Where(p => p.Locationid == id)
                .ToList());
        }

        public void UpdateInventory(Inventory Inventory)
        {
            context.Inventories.Update(mapper.ParseInventory(Inventory));
            context.SaveChanges();            
        }

        public void DeleteInventory(Inventory Inventory)
        {
            context.Inventories.Remove(mapper.ParseInventory(Inventory));
            context.SaveChanges();
        }

        public void AddLocation(Location Location)
        {
            context.Locations.Add(mapper.ParseLocation(Location));
            context.SaveChanges();
        }
        public List<Location> GetAllLocations()
        {
            return mapper.ParseLocation(
                context.Locations
                .ToList()
            );
        }

        public Location GetLocation(int id)
        {
            return mapper.ParseLocation(context.Locations
            .First(x => x.Locationid == id));
        }

        public void UpdateLocation(Location Location)
        {
            context.Locations.Update(mapper.ParseLocation(Location));
            context.SaveChanges();
        }

        public void DeleteLocation(Location Location)
        {
            context.Locations.Remove(mapper.ParseLocation(Location));
            context.SaveChanges();
        }

        public void AddManager(Manager Manager)
        {
            context.Managers.Add(mapper.ParseManager(Manager));
            context.SaveChanges();
        }

        public Manager GetManager(int id)
        {
            return mapper.ParseManager(
                context.Managers
                .First(p => p.Managerid == id));
        }
        public List<Manager> GetAllManagers()
        {
            return mapper.ParseManager(
                context.Managers
                .ToList()
            );
        }

        public void UpdateManager(Manager Manager)
        {
            context.Managers.Update(mapper.ParseManager(Manager));
            context.SaveChanges();
        }

        public void DeleteManager(Manager Manager)
        {
            context.Managers.Remove(mapper.ParseManager(Manager));
            context.SaveChanges();;
        }

        public void AddCartItem(CartItem CartItem)
        {
            context.CartItems.Add(mapper.ParseCartItem(CartItem));
            context.SaveChanges();
        }

        public CartItem GetCartItem(int id)
        {
            return mapper.ParseCartItem(
                context.CartItems
                .First(p => p.Cartitemid == id));
        }

        public void UpdateCartItem(CartItem CartItem)
        {
            context.CartItems.Update(mapper.ParseCartItem(CartItem));
            context.SaveChanges();
        }

        public void DeleteCartItem(CartItem CartItem)
        {
            context.CartItems.Remove(mapper.ParseCartItem(CartItem));
            context.SaveChanges();
        }

        public void AddOrderItem(OrderItem OrderItem)
        {
            context.OrderItems.Add(mapper.ParseOrderItem(OrderItem));
            context.SaveChanges();
        }

        public OrderItem GetOrderItem(int id)
        {
            return mapper.ParseOrderItem(
                context.OrderItems
                .First(p => p.Orderitemid == id));
        }
        public List<OrderItem> GetAllOrderItems()
        {
            return mapper.ParseOrderItem(
                context.OrderItems
                .ToList()
            );
        }
        public List<OrderItem> GetOrderItemsExpensive(Double num)
        {
            throw new System.NotImplementedException();
        }
        
        public List<OrderItem> GetOrderItemsCheap(Double num)
        {
            throw new System.NotImplementedException();
        }
        public List<OrderItem> GetOrderItemDateEarly(DateTime date)
        {
            throw new System.NotImplementedException();
        }
        public List<OrderItem> GetOrderItemDateLate(DateTime date)
        {
            throw new System.NotImplementedException();
        }
        public void UpdateOrderItem(OrderItem OrderItem)
        {
            context.OrderItems.Update(mapper.ParseOrderItem(OrderItem));
            context.SaveChanges();
        }

        public void DeleteOrderItem(OrderItem OrderItem)
        {
            context.OrderItems.Remove(mapper.ParseOrderItem(OrderItem));
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
                    .First(c => c.Customerid == id));

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

        public Product GetProduct(int id)
        {
            return mapper.ParseProduct(
                context.Products
                .First(p => p.Productid == id)
            );
        }
        public List<Product> GetAllProducts()
        {
            return mapper.ParseProduct(
                context.Products
                .ToList()
            );
        }
        public void AddProduct(Product Product)
        {
            context.Products.Add(mapper.ParseProduct(Product));
            context.SaveChanges();
        }
        public void UpdateProduct(Product Product)
        {
            context.Products.Update(mapper.ParseProduct(Product));
            context.SaveChanges();
        }

        public void DeleteProduct(Product Product)
        {
            context.Products.Remove(mapper.ParseProduct(Product));
            context.SaveChanges();
        }
    }
}
