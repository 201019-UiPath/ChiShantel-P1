using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface IInventoryRepo
    {
       void AddInventory(Inventory Inventory);
       List<Inventory> GetInventory(int id);

       void UpdateInventory(Inventory Inventory);
       void DeleteInventory(Inventory Inventory);
    }
}