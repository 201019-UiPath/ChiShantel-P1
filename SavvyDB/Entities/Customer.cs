using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Cart = new HashSet<Cart>();
            Orders = new HashSet<Orders>();
        }

        public int Custid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
