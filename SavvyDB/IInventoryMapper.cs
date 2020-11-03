using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB
{
    public interface IInventory
    {
         Inventory ParseInventory(Inventory Inventory);

         ICollection<Inventory> ParseInventory(List<Inventory> Inventory);

         List<Inventory> ParseInventory(ICollection<Inventory> Inventory);
    }
}