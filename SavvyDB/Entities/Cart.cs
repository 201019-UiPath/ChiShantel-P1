using System;
using System.Collections.Generic;

namespace SavvyUI.Entities
{
    public partial class Cart
    {
        public int Cartid { get; set; }
        public int? Custid { get; set; }
        public int? Productid { get; set; }
        public int? Locationid { get; set; }
        public int? Quantity { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual Location Location { get; set; }
        public virtual Products Product { get; set; }
    }
}
