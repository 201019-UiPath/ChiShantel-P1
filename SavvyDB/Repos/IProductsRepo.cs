using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface IProductsRepo
    {
         void AddProduct(Products Products);
         Products GetProduct(int id);
         List<Products> GetAllProducts();
         void UpdateProduct(Products Products);
         void DeleteProduct(Products Products);
    }
}