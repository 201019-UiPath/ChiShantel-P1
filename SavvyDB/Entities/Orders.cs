using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int Custid { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
