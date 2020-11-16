using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyLib
{
    public interface IInventoryTask
    {
        public void AddInventory(Inventory Inventory);

        public Inventory GetInventory(int id);

        public void UpdateInventory(Inventory Inventory);

        public List<Inventory> GetInventoryByLocation(int id);
        public void RemoveInventory(Inventory Inventory);
    }
}