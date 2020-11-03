using System.Collections.Generic;
namespace SavvyDB.Models
{
    public class Cart
    {
     public int id {get; set;}
     public int? custid {get; set;} 
     public int? productid {get; set;}
     public int? locationid {get; set;}
     public int? quantity {get; set;}
    }
}