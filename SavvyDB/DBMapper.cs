using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB
{
    public class DBMapper : ICustomerMapper, IManagerMapper, IProductMapper, ICartMapper, IInventoryMapper
    {
        public Customers ParseCustomer(Customer Customer)
        {
            return new Customers() 
            {
                fname = Customer.fname,
                lname = Customer.lname,
                email = Customer.email
            };
        }
        public ICollection<Customers> ParseCustomer(List<Customer> Customer)
        {
            ICollection<Customers> Customers = new List<Customers>();
            foreach (var cust in Customer)
            {
                Customers.Add(ParseCustomer(cust));
            }
            return Customers;
        }
        public Customer ParseCustomer(Customers Customer)
        {
            return new Customers()
            {
                fname = Customer.fname,
                lname = Customer.lname,
                email = Customer.email
            };
        }
        public List<Customer> ParseCustomer(ICollection<Customers> Customer)
        {
            List<Customer> Customers = new List<Customer>();
            foreach (var cust in Customer)
                {
                    Customers.Add(ParseCustomer(cust));
                }
            return Customers;
        }
        //From DB
        public Managers ParseManager(Manager Manager)
        {
            return new Managers()
            {
                Fname = Manager.fname,
                Lname = Manager.lname,
                Email = Manager.email,
                Location = Manager.locationid
            };
        }
        //To DB
        public Manager ParseManager(Managers Manager)
        {
            return new Manager()
            {
                fname = Manager.Fname,
                lname = Manager.Lname,
                email = Manager.Email,
                locationid = Manager.Location
            };
        }
        public List<Manager> ParseManager(ICollection<Managers> Manager)
        {
            List<Manager> Managers = new List<Manager>();
            foreach (var manager in Managers)
            {
                Managers.Add(ParseManager(manager));
            }
            return Managers;
        }
        public ICollection<Managers> ParseManager(List<Manager> Manager)
        {
            ICollection<Managers> Managers = new List<Manager>();
            foreach (var manager in Managers)
            {
                Managers.Add(ParseManager(manager));
            }
            return Managers;
        }
        public Products ParseProduct(Products Product)
        {
            return new Product()
            {
                Name = Product.productname,
                Price = Product.productcost
            };
        }
        public Products ParseProduct(Products Product)
        {
            return new Product()
            {
                productname = Product.Name,
                productcost = Product.Price
            };
        }
        public ICollection<Products> ParseProduct(List<Products> Products)
        {
            ICollection<Products> Products = new List<Products>();
            foreach (var product in Products)
            {
                Products.Add(ParseProduct(product));
            }
            return Products;
        }
        public List<Products> ParseProduct(ICollection<Products> Products)
        {
            List<Products> Products = new List<Products>();
            foreach (var product in Products)
            {
                Products.Add(ParseProduct(product));
            }
            return Products;
        }
        public Cart ParseCart(Cart Cart)
        {
            return new Cart()
            {
                custid = Cart.custid,
                productid = Cart.productid,
                locationid = Cart.locationid,
                quantity = Cart.Quantity
            };
        }
        public List<Cart> ParseCart(ICollection<Cart> Cart)
        {
            List<Cart> Cart = new List<Cart>();
            foreach (var cart in Cart)
            {
                Cart.Add(ParseCart(cart));
            }
            return Cart;
        }
        public ICollection<Cart> ParseCart(List<Cart> Cart)
        {
            ICollection<Cart> Cart = new List<Cart>();
            foreach (var cart in Cart)
            {
                Cart.Add(ParseCart(cart));
            }
            return Cart;
        }
        public Inventory ParseInventory(Inventory Inventory)
        {
            return new Inventory()
            {
                productid = Inventory.productid,
                quantity = Inventory.quantity
            };
        }
        public ICollection<Inventory> ParseInventory(List<Inventory> Inventory)
        {
            ICollection<Inventory> Inventory = new List<Inventory>();
            foreach (var inventory in Inventory)
            {
                Inventory.Add(ParseInventory(product));
            }
            return Inventory;
        }
        public List<Inventory> ParseInventory(ICollection<Inventory> Inventory)
        {
            List<Inventory> Inventory = new List<Inventory>();
            foreach (var inventory in Inventory)
            {
                Inventory.Add(ParseInventory(inventory));
            }
            return Inventory;
        }
    }
}