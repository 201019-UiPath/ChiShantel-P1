using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SavvyAPI.Models
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string ProductName { get; set; }
        [Required]
        public decimal Cost { get; set; }
    }
}
