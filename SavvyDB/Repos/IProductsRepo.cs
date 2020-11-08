using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface IProductsRepo
    {
         void AddProduct(Product Products);
         Product GetProduct(int id);
         List<Product> GetAllProducts();
         void UpdateProduct(Product Products);
         void DeleteProduct(Product Products);
    }
}