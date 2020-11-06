using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface IProductsRepo
    {
         void AddProduct(Products Products);
         List<Products> GetProduct(Products Products);
         void UpdateProduct(Products Products);
         void DeleteProduct(Products Products);
    }
}