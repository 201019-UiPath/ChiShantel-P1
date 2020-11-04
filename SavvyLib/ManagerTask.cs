using SavvyDB.Models;
using SavvyDB;
using System.Collections.Generic;
using System; 

namespace SavvyLib
{
    public class ManagerTask
    {
        private IManagerRepo repo;

        public ManagerTask(IManagerRepo repo)
        {
            this.repo = repo;
        }
        /*public void addManager(Manager newManager)
        {
            repo.AddManager(newManager);
        }
        public List<Products> GetProducts()
        {
            Task<List<Products>> getProductsTask = repo.GetProducts;
            return getProductsTask.Result;
        }*/
    }
}