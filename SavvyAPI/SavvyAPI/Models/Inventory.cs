using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavvyAPI.Models
{
    public class Inventory
    {
        public int Inventoryid { get; set; }
        public int Locationid { get; set; }
        public int Productid { get; set; }
        public int Quantity { get; set; }
    }
}
