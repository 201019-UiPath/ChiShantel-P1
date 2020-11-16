using SavvyDB;
using SavvyDB.Models;
using System.Collections.Generic;

namespace SavvyLib
{
    public class ProductTask : IProductTask
    {
        private IProductsRepo repo;

        public ProductTask(IProductsRepo repo)
        {
            this.repo = repo;
        }
        public void AddProduct(Product Product)
        {
            repo.AddProduct(Product);
        }
        public Product GetProduct(int id)
        {
            return repo.GetProduct(id);
        }
        public List<Product> GetAllProducts()
        {
            return repo.GetAllProducts();
        }
        public void UpdateProduct(Product Product)
        {
            repo.UpdateProduct(Product);
        }
        public void RemoveProduct(Product Product)
        {
            repo.DeleteProduct(Product);
        }
    }
}