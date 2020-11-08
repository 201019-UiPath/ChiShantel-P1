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
                Fname = Customer.Fname,
                Lname = Customer.Lname,
                Email = Customer.Email
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
                Fname = Customer.Fname,
                Lname = Customer.Lname,
                Email = Customer.Email
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
        public Managers ParseManager(Manager Manager)
        {
            return new Managers()
            {
                Fname = Manager.Fname,
                Lname = Manager.Lname,
                Email = Manager.Email,
                Locationid = Manager.LocationId
            };
        }
        public Manager ParseManager(Managers Manager)
        {
            return new Manager()
            {
                Fname = Manager.Fname,
                Lname = Manager.Lname,
                Email = Manager.Email,
                LocationId = Manager.Locationid
            };
        }
        public ICollection<Managers> ParseManager(List<Manager> Manager)
        {
            ICollection<Managers> Managers = new List<Managers>();
            foreach (var manager in Manager)
            {
                Managers.Add(ParseManager(manager));
            }
            return Managers;
        }
        public List<Manager> ParseManager(ICollection<Managers> Manager)
        {
            List<Manager> Managers = new List<Manager>();
            foreach (var manager in Manager)
            {
                Managers.Add(ParseManager(manager));
            }
            return Managers;
        } 
        public Products ParseProduct(Product Product)
        {
            return new Products()
            {
                Productname = Product.Name,
                Cost = Product.Cost
            };
        }
        public Product ParseProduct(Products Product)
        {
            return new Product()
            {
                Name = Product.Productname,
                Cost = Product.Cost
            };
        }
        public ICollection<Products> ParseProduct(List<Product> Product)
        {
            ICollection<Products> Products = new List<Products>();
            foreach (var product in Product)
            {
                Products.Add(ParseProduct(product));
            }
            return Products;
        }
        public List<Product> ParseProduct(ICollection<Products> Product)
        {
            List<Product> Products = new List<Product>();
            foreach (var product in Product)
            {
                Products.Add(ParseProduct(product));
            }
            return Products;
        }
        public Carts ParseCart(Cart Cart)
        {
            return new Carts()
            {
                Customerid = Cart.CustomerId,
                Cartid = Cart.CartId
            };
        }
        public Cart ParseCart(Carts Cart)
        {
            return new Cart()
            {
                CustomerId = Cart.Customerid,
                CartId = Cart.Cartid
            };
        }
        public List<Cart> ParseCart(ICollection<Carts> Carts)
        {
            List<Cart> Cart = new List<Cart>();
            foreach (var cart in Carts)
            {
                Cart.Add(ParseCart(cart));
            }
            return Cart;
        }
        public ICollection<Carts> ParseCart(List<Cart> Carts)
        {
            ICollection<Carts> Cart = new List<Carts>();
            foreach (var cart in Carts)
            {
                Cart.Add(ParseCart(cart));
            }
            return Cart;
        }
        public Inventories ParseInventory(Inventory Inventory)
        {
            return new Inventories()
            {
                Locationid = Inventory.LocationId,
                Productid = Inventory.ProductId,
                Quantity = Inventory.Quantity
            };
        }
        public Inventory ParseInventory(Inventories Inventory)
        {
            return new Inventory()
            {
                LocationId = Inventory.Locationid,
                ProductId = Inventory.Productid,
                Quantity = Inventory.Quantity
            };
        }
        public List<Inventory> ParseInventory(ICollection<Inventories> Inventory)
        {
            List<Inventory> Inventories = new List<Inventory>();
            foreach (var inventory in Inventory)
            {
                Inventories.Add(ParseInventory(inventory));
            }
            return Inventories;
        }
        public ICollection<Inventories> ParseInventory(List<Inventory> Inventory)
        {
            ICollection<Inventories> Inventories = new List<Inventories>();
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
                LocationId = Location.Locationid
            };
        }
        public Locations ParseLocation(Location Location)
        {
            return new Locations()
            {
                Name = Location.Name,
                Locationid = Location.LocationId
            };
        }
 
        public List<Location> ParseLocation(ICollection<Locations> Locations)
        {
            List<Location> Location = new List<Location>();
            foreach (var location in Locations)
            {
                Location.Add(ParseLocation(location));
            }
            return Location;
        }
        public ICollection<Locations> ParseLocation(List<Location> Locations)
        {
            ICollection<Locations> Location = new List<Locations>();
            foreach (var location in Locations)
            {
                Location.Add(ParseLocation(location));
            }
            return Location;
        }

        public CartItems ParseCartItem(CartItem CartItem)
        {
            return new CartItems()
            {
                Cartitemid = CartItem.CartItemId,
                Productid = CartItem.ProductId,
                Cartid = CartItem.CartId 
            };
        }

        public CartItem ParseCartItem(CartItems CartItem)
        {
            return new CartItem()
            {
                CartItemId = CartItem.Cartitemid,
                ProductId = CartItem.Productid,
                CartId = CartItem.Cartid 
            };
        }

        public ICollection<CartItems> ParseCartItem(List<CartItem> CartItem)
        {
            ICollection<CartItems> CartItems = new List<CartItems>();
            foreach (var cartitem in CartItem)
            {
                CartItems.Add(ParseCartItem(cartitem));
            }
            return CartItems;
        }

        public List<CartItem> ParseCartItem(ICollection<CartItems> CartItem)
        {
            List<CartItem> CartItems = new List<CartItem>();
            foreach (var cartitem in CartItem)
            {
                CartItems.Add(ParseCartItem(cartitem));
            }
            return CartItems;
        }

        public OrderItems ParseOrderItem(OrderItem OrderItem)
        {
            return new OrderItems()
            {
                Orderitemid = OrderItem.OrderItemId,
                Productid = OrderItem.ProductId,
                Orderid = OrderItem.OrderId 
            };
        }

        public OrderItem ParseOrderItem(OrderItems OrderItem)
        {
            return new OrderItem()
            {
                OrderItemId = OrderItem.Orderitemid,
                ProductId = OrderItem.Productid,
                OrderId = OrderItem.Orderid 
            };
        }

        public ICollection<OrderItems> ParseOrderItem(List<OrderItem> OrderItem)
        {
            ICollection<OrderItems> OrderItems = new List<OrderItems>();
            foreach (var orderitem in OrderItem)
            {
                OrderItems.Add(ParseOrderItem(orderitem));
            }
            return OrderItems;
        }

        public List<OrderItem> ParseOrderItem(ICollection<OrderItems> OrderItem)
        {
            List<OrderItem> OrderItems = new List<OrderItem>();
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
                Orderid = Order.OrderId,
                Customerid = Order.CustomerId,
            };
        }

        public Order ParseOrder(Orders Order)
        {
            return new Order()
            {
                OrderId = Order.Orderid,
                CustomerId = Order.Customerid
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
            List<Order> Orders = new List<Order>();
            foreach (var order in Order)
            {
                Orders.Add(ParseOrder(order));
            }
            return Orders;
        }

    }
}