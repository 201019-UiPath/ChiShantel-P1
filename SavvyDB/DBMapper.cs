/*using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;

namespace SavvyDB
{
    public class DBMapper : IMapper
    {
        public Customers ParseCustomer(Customer Customer)
        {
            return new Customers() 
            {
                fname = Customer.Fname,
                lname = Customer.Lname,
                email = Customer.Email
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
            return new Customer()
            {
                Fname = Customer.fname,
                Lname = Customer.lname,
                Email = Customer.email
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
                Fname = Manager.Fname,
                Lname = Manager.Lname,
                Email = Manager.Email,
                Location = Manager.Locationid
            };
        }
        //To DB
        public Manager ParseManager(Managers Manager)
        {
            return new Manager()
            {
                Fname = Manager.Fname,
                Lname = Manager.Lname,
                Email = Manager.Email,
                Locationid = Manager.Location
            };
        }
        public ICollection<Manager> ParseManager(ICollection<Managers> Manager)
        {
            List<Manager> Managers = new List<Manager>();
            foreach (var manager in Manager)
            {
                Managers.Add(ParseManager(manager));
            }
            return Managers;
        }
        public List<Manager> ParseManager(List<Managers> Manager)
        {
            List<Manager> Managers = new List<Manager>();
            foreach (var manager in Manager)
            {
                Managers.Add(ParseManager(manager));
            }
            return Managers;
        } 
        public SavvyDB.Entities.Products ParseProduct(SavvyDB.Models.Products Product)
        {
            return new SavvyDB.Entities.Products()
            {
                Productname = Product.Name,
                Productcost = Product.Price
            };
        }
        public SavvyDB.Models.Products ParseProduct(SavvyDB.Entities.Products Product)
        {
            return new SavvyDB.Models.Products()
            {
                Name = Product.Productname,
                Price = Product.Productcost
            };
        }
        public ICollection<SavvyDB.Models.Products> ParseProduct(List<SavvyDB.Entities.Products> Product)
        {
            ICollection<SavvyDB.Models.Products> Products = new List<SavvyDB.Models.Products>();
            foreach (var product in Product)
            {
                Products.Add(ParseProduct(product));
            }
            return Products;
        }
        public List<SavvyDB.Entities.Products> ParseProduct(ICollection<SavvyDB.Models.Products> Product)
        {
            List<SavvyDB.Entities.Products> Products = new List<SavvyDB.Entities.Products>();
            foreach (var product in Product)
            {
                Products.Add(ParseProduct(product));
            }
            return Products;
        }
        public SavvyDB.Entities.Cart ParseCart(SavvyDB.Models.Cart Cart)
        {
            return new SavvyDB.Entities.Cart()
            {
                Custid = Cart.custid,
                Productid = Cart.productid,
                Locationid = Cart.locationid,
                Quantity = Cart.quantity
            };
        }
        public SavvyDB.Models.Cart ParseCart(SavvyDB.Entities.Cart Cart)
        {
            return new SavvyDB.Models.Cart()
            {
                custid = Cart.Custid,
                productid = Cart.Productid,
                locationid = Cart.Locationid,
                quantity = Cart.Quantity
            };
        }
        public List<SavvyDB.Entities.Cart> ParseCart(List<SavvyDB.Models.Cart> Carts)
        {
            List<SavvyDB.Entities.Cart> Cart = new List<SavvyDB.Entities.Cart>();
            foreach (var cart in Carts)
            {
                Cart.Add(ParseCart(cart));
            }
            return Cart;
        }
        public ICollection<SavvyDB.Models.Cart> ParseCart(ICollection<SavvyDB.Entities.Cart> Carts)
        {
            ICollection<SavvyDB.Models.Cart> Cart = new List<SavvyDB.Models.Cart>();
            foreach (var cart in Carts)
            {
                Cart.Add(ParseCart(cart));
            }
            return Cart;
        }
        public SavvyDB.Entities.Inventory ParseInventory(SavvyDB.Models.Inventory Inventory)
        {
            return new SavvyDB.Entities.Inventory()
            {
                Locationid = Inventory.locationid,
                Productid = Inventory.productid,
                Quantity = Inventory.quantity
            };
        }
        public SavvyDB.Models.Inventory ParseInventory(SavvyDB.Entities.Inventory Inventory)
        {
            return new SavvyDB.Models.Inventory()
            {
                locationid = Inventory.Locationid,
                productid = Inventory.Productid,
                quantity = Inventory.Quantity
            };
        }
        public List<SavvyDB.Models.Inventory> ParseInventory(List<SavvyDB.Entities.Inventory> Inventory)
        {
            List<SavvyDB.Models.Inventory> Inventories = new List<SavvyDB.Models.Inventory>();
            foreach (var inventory in Inventory)
            {
                Inventories.Add(ParseInventory(inventory));
            }
            return Inventories;
        }
        public ICollection<SavvyDB.Entities.Inventory> ParseInventory(ICollection<SavvyDB.Models.Inventory> Inventory)
        {
            ICollection<SavvyDB.Entities.Inventory> Inventories = new List<SavvyDB.Entities.Inventory>();
            foreach (var inventory in Inventory)
            {
                Inventories.Add(ParseInventory(inventory));
            }
            return Inventories;
        }
        public Location ParseLocation(Locations Location)
        {
            return new Location()
            {
                Name = Location.Name,
                Employees = Location.Employees
            };
        }
        public Locations ParseLocation(Location Location)
        {
            return new Locations()
            {
                Name = Location.Name,
                Employees = Location.Employees
            };
        }
        public ICollection<Location> ParseLocation(ICollection<Locations> Location)
        {
            ICollection<Location> Locations = new List<Location>();
            foreach (var location in Location)
            {
                Locations.Add(ParseLocation(location));
            }
            return Locations;
        } 
        public List<Location> ParseLocation(List<Locations> Locations)
        {
            List<Location> Location = new List<Location>();
            foreach (var location in Locations)
            {
                Location.Add(ParseLocation(location));
            }
            return Location;
        } 
    }
}*/