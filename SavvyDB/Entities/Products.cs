using System;
using System.Collections.Generic;

namespace SavvyUI.Entities
{
    public partial class Products
    {
        public Products()
        {
            Cart = new HashSet<Cart>();
            Inventory = new HashSet<Inventory>();
        }

        public int Productid { get; set; }
        public string Productname { get; set; }
        public string Description { get; set; }
        public decimal? Productcost { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
