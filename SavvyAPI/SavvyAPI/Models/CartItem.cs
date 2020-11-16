using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SavvyAPI.Models
{
    public class CartItem
    {
        public int Cartitemid { get; set; }
        public int Cartid { get; set; }
        public int Productid { get; set; }
        public int Quantity { get; set; }
    }
}
