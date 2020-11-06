using System.Collections.Generic;
namespace SavvyDB.Entities
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int Custid { get; set; }
        public virtual Customer Cust { get; set; }
        public virtual ICollection<CartItem> CartItem { get; set; }
    }
}
