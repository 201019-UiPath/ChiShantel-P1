using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class OrderItems
    {
        public int Orderitemid { get; set; }
        public int Orderid { get; set; }
        public int Productid { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
