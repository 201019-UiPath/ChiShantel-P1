using System.Collections.Generic;
namespace SavvyDB.Entities

{
    public partial class Products
    {
        public Products()
        {
            CartItem = new HashSet<CartItem>();
            Inventory = new HashSet<Inventory>();
            OrderItem = new HashSet<OrderItem>();
        }
        public int Productid { get; set; }
        public string Productname { get; set; }
        public string Description { get; set; }
        public decimal? Productcost { get; set; }
        public virtual ICollection<CartItem> CartItem { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
