using SavvyDB;
using SavvyDB.Models;
using System.Collections.Generic;

namespace SavvyLib
{
    public class InventoryTask : IInventoryTask
    {
        private IInventoryRepo repo;
        public InventoryTask(IInventoryRepo repo)
        {
            this.repo = repo;
        }

        public void AddInventory(Inventory Inventory)
        {
            repo.AddInventory(Inventory);
        }
        public List<Inventory> GetInventoryByLocation(int id)
        {
            return repo.GetInventoryByLocation(id);
        }
        public Inventory GetInventory(int id)
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