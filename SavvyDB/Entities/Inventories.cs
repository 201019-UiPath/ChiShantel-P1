using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class Inventories
    {
        public int Inventoryid { get; set; }
        public int Locationid { get; set; }
        public int Productid { get; set; }
        public int Quantity { get; set; }

        public virtual Locations Location { get; set; }
        public virtual Products Product { get; set; }
    }
}
