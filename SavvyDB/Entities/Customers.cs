using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class Customers
    {
        public Customers()
        {
            Carts = new HashSet<Carts>();
        }

        public int Customerid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Carts> Carts { get; set; }
    }
}
