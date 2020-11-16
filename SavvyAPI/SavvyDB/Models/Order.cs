using System;
namespace SavvyDB.Models

{
    public class Order
    {
        public int OrderId {get; set;}
        public int CustomerId {get; set;}
        public decimal Totalprice { get; set; }
        public DateTime Date { get; set; }
    }
}