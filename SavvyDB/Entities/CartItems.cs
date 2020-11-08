using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class CartItems
    {
        public int Cartitemid { get; set; }
        public int Cartid { get; set; }
        public int Productid { get; set; }
        public int Quantity { get; set; }

        public virtual Carts Cart { get; set; }
        public virtual Products Product { get; set; }
    }
}
