using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class Carts
    {
        public Carts()
        {
            CartItems = new HashSet<CartItems>();
        }

        public int Cartid { get; set; }
        public int Customerid { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<CartItems> CartItems { get; set; }
    }
}
