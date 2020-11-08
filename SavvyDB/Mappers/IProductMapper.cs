using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface IProductMapper
    {
         Products ParseProduct(Product Product);
         Product ParseProduct(Products Product);
         ICollection<Products> ParseProduct(List<Product> Product);
         List<Product> ParseProduct(ICollection<Products> Product);
         
    }
}