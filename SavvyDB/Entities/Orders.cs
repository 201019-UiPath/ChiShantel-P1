using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public int Orderid { get; set; }
        public int Customerid { get; set; }
        public decimal Totalprice { get; set; }
        public DateTime Date { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
