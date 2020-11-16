using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB

{
    public interface IManagerRepo
    {
         void AddManager(Manager Manager);
         Manager GetManager(int id);
         List<Manager> GetAllManagers();
         void UpdateManager(Manager Manager);
         void DeleteManager(Manager Manager);
    }
}