using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface IInventoryMapper
    {
         Inventories ParseInventory(Inventory Inventory);
         Inventory ParseInventory(Inventories Inventory);
         List<Inventory> ParseInventory(ICollection<Inventories> Inventory);
         ICollection<Inventories> ParseInventory(List<Inventory> Inventory);
    }
}