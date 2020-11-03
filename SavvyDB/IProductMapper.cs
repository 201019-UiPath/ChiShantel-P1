using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB
{
    public interface IProduct
    {
         Products ParseProduct(Products Products);

         ICollection<Products> ParseProduct(List<Products> Product);
         
         Products ParseProduct(Products Products);

         List<Products> ParseProduct(ICollection<Products> Product);
    }
}