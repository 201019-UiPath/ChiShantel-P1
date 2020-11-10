using SavvyDB;
using SavvyDB.Models;
using System.Collections.Generic;

namespace SavvyLib
{
    public class InventoryTask
    {
        private SavvyRepo repo;
        public InventoryTask(SavvyRepo repo)
        {
            this.repo = repo;
        }

        public void AddInventory(Inventory Inventory)
        {
            repo.AddInventory(Inventory);
        }
        public List<Inventory> GetInventory(int id)
        {
            return repo.GetInventory(id);
        }
        public void UpdateInventory(Inventory Inventory)
        {
            repo.UpdateInventory(Inventory);
        }
        public void RemoveInventory(Inventory Inventory)
        {
            repo.DeleteInventory(Inventory);
        }
    }
}