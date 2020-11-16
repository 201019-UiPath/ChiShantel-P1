using System.ComponentModel;
namespace SavvyDB.Models

{
    public class Inventory
    {
        public int InventoryId {get; set;}
        public int LocationId {get; set;}
        public int ProductId {get; set;}
        [DisplayName("Quantity")]
        public int Quantity {get; set;}
    }
}