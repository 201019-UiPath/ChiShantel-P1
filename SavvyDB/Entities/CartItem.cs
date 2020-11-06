namespace SavvyDB.Entities

{
    public partial class CartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public int Productid { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual Products Product { get; set; }
    }
}
