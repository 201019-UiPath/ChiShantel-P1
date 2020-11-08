using SavvyDB;
using SavvyDB.Models;

namespace SavvyLib
{
    public class ProductTask
    {
        private SavvyRepo repo;

        public ProductTask(SavvyRepo repo)
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