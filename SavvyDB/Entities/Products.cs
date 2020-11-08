using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class Products
    {
        public Products()
        {
            CartItems = new HashSet<CartItems>();
            Inventories = new HashSet<Inventories>();
            OrderItems = new HashSet<OrderItems>();
        }

        public int Productid { get; set; }
        public string Productname { get; set; }
        public decimal Cost { get; set; }

        public virtual ICollection<CartItems> CartItems { get; set; }
        public virtual ICollection<Inventories> Inventories { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
