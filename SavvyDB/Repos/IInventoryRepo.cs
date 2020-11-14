using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface IInventoryRepo
    {
       void AddInventory(Inventory Inventory);
       List<Inventory> GetInventoryByLocation(int id);
       List <Inventory> GetProductsByLocation(int id);
       Inventory GetInventory(int id);
       void UpdateInventory(Inventory Inventory);
       void DeleteInventory(Inventory Inventory);
    }
}