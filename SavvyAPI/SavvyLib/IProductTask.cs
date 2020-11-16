using SavvyDB.Models;
using SavvyDB;
using System.Collections.Generic;
namespace SavvyLib
{
    public interface IProductTask
    {
        public void AddProduct(Product Product);

        public Product GetProduct(int id);

        List<Product> GetAllProducts();

        public void UpdateProduct(Product Product);

        public void RemoveProduct(Product Product);

    }
}