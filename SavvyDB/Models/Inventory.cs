namespace SavvyDB.Models

{
    public class Inventory
    {
        public int Id {get; set;}
        public int locationid {get; set;}
        public int? productid {get; set;}
        public int? quantity {get; set;}
    }
}