using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;

namespace SavvyDB.Mappers
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
        public ICollection<Customer> ParseCustomer(List<Customers> Customer)
        {
            ICollection<Customer> Customers = new List<Customer>();
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
        public List<Customers> ParseCustomer(ICollection<Customer> Customer)
        {
            List<Customers> Customers = new List<Customers>();
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
        public ICollection<Manager> ParseManager(List<Managers> Manager)
        {
            ICollection<Manager> Managers = new List<Manager>();
            foreach (var manager in Manager)
            {
                Managers.Add(ParseManager(manager));
            }
            return Managers;
        }
        public List<Managers> ParseManager(ICollection<Manager> Manager)
        {
            List<Managers> Managers = new List<Managers>();
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
        public ICollection<SavvyDB.Entities.Products> ParseProduct(List<SavvyDB.Models.Products> Product)
        {
            ICollection<SavvyDB.Entities.Products> Products = new List<SavvyDB.Entities.Products>();
            foreach (var product in Product)
            {
                Products.Add(ParseProduct(product));
            }
            return Products;
        }
        public List<SavvyDB.Models.Products> ParseProduct(ICollection<SavvyDB.Entities.Products> Product)
        {
            List<SavvyDB.Models.Products> Products = new List<SavvyDB.Models.Products>();
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
                CartId = Cart.cartid
            };
        }
        public SavvyDB.Models.Cart ParseCart(SavvyDB.Entities.Cart Cart)
        {
            return new SavvyDB.Models.Cart()
            {
                custid = Cart.Custid,
                cartid = Cart.CartId
            };
        }
        public List<SavvyDB.Models.Cart> ParseCart(ICollection<SavvyDB.Entities.Cart> Carts)
        {
            List<SavvyDB.Models.Cart> Cart = new List<SavvyDB.Models.Cart>();
            foreach (var cart in Carts)
            {
                Cart.Add(ParseCart(cart));
            }
            return Cart;
        }
        public ICollection<SavvyDB.Entities.Cart> ParseCart(List<SavvyDB.Models.Cart> Carts)
        {
            ICollection<SavvyDB.Entities.Cart> Cart = new List<SavvyDB.Entities.Cart>();
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
                LocationId = Inventory.locationid,
                ProductId = Inventory.productid,
                Quantity = Inventory.quantity
            };
        }
        public SavvyDB.Models.Inventory ParseInventory(SavvyDB.Entities.Inventory Inventory)
        {
            return new SavvyDB.Models.Inventory()
            {
                locationid = Inventory.LocationId,
                productid = Inventory.ProductId,
                quantity = Inventory.Quantity
            };
        }
        public List<SavvyDB.Models.Inventory> ParseInventory(ICollection<SavvyDB.Entities.Inventory> Inventory)
        {
            List<SavvyDB.Models.Inventory> Inventories = new List<SavvyDB.Models.Inventory>();
            foreach (var inventory in Inventory)
            {
                Inventories.Add(ParseInventory(inventory));
            }
            return Inventories;
        }
        public ICollection<SavvyDB.Entities.Inventory> ParseInventory(List<SavvyDB.Models.Inventory> Inventory)
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
 
        public List<Locations> ParseLocation(ICollection<Location> Locations)
        {
            List<Locations> Location = new List<Locations>();
            foreach (var location in Locations)
            {
                Location.Add(ParseLocation(location));
            }
            return Location;
        }
        public ICollection<Location> ParseLocation(List<Locations> Locations)
        {
            ICollection<Location> Location = new List<Location>();
            foreach (var location in Locations)
            {
                Location.Add(ParseLocation(location));
            }
            return Location;
        }

        public Entities.CartItem ParseCartItem(Models.CartItem CartItem)
        {
            return new Entities.CartItem()
            {
                CartItemId = CartItem.CartItemId,
                Productid = CartItem.ProductId,
                CartId = CartItem.CartId 
            };
        }

        public Models.CartItem ParseCartItem(Entities.CartItem CartItem)
        {
            return new Models.CartItem()
            {
                CartItemId = CartItem.CartItemId,
                ProductId = CartItem.Productid,
                CartId = CartItem.CartId 
            };
        }

        public ICollection<Entities.CartItem> ParseCartItem(List<Models.CartItem> CartItem)
        {
            ICollection<Entities.CartItem> CartItems = new List<Entities.CartItem>();
            foreach (var cartitem in CartItem)
            {
                CartItems.Add(ParseCartItem(cartitem));
            }
            return CartItems;
        }

        public List<Models.CartItem> ParseCartItem(ICollection<Entities.CartItem> CartItem)
        {
            List<Models.CartItem> CartItems = new List<Models.CartItem>();
            foreach (var cartitem in CartItem)
            {
                CartItems.Add(ParseCartItem(cartitem));
            }
            return CartItems;
        }

        public Entities.OrderItem ParseOrderItem(Models.OrderItem OrderItem)
        {
            return new Entities.OrderItem()
            {
                OrderItemId = OrderItem.OrderItemId,
                ProductId = OrderItem.ProductId,
                OrderId = OrderItem.OrderId 
            };
        }

        public Models.OrderItem ParseOrderItem(Entities.OrderItem OrderItem)
        {
            return new Models.OrderItem()
            {
                OrderItemId = OrderItem.OrderItemId,
                ProductId = OrderItem.ProductId,
                OrderId = OrderItem.OrderId 
            };
        }

        public ICollection<Entities.OrderItem> ParseOrderItem(List<Models.OrderItem> OrderItem)
        {
            ICollection<Entities.OrderItem> OrderItems = new List<Entities.OrderItem>();
            foreach (var orderitem in OrderItem)
            {
                OrderItems.Add(ParseOrderItem(orderitem));
            }
            return OrderItems;
        }

        public List<Models.OrderItem> ParseOrderItem(ICollection<Entities.OrderItem> OrderItem)
        {
            List<Models.OrderItem> OrderItems = new List<Models.OrderItem>();
            foreach (var orderitem in OrderItem)
            {
                OrderItems.Add(ParseOrderItem(orderitem));
            }
            return OrderItems;
        }

        public Orders ParseOrder(Order Order)
        {
            return new Orders()
            {
                OrderId = Order.Orderid,
                Custid = Order.CustId,
            };
        }

        public Order ParseOrder(Orders Order)
        {
            return new Order()
            {
                Orderid = Order.OrderId,
                CustId = Order.Custid
            };
        }

        public ICollection<Orders> ParseOrder(List<Order> Order)
        {
            ICollection<Orders> Orders = new List<Orders>();
            foreach (var order in Order)
            {
                Orders.Add(ParseOrder(order));
            }
            return Orders;
        }

        public List<Order> ParseOrder(ICollection<Orders> Order)
        {
            List<Models.Order> Orders = new List<Models.Order>();
            foreach (var order in Order)
            {
                Orders.Add(ParseOrder(order));
            }
            return Orders;
        }

    }
}