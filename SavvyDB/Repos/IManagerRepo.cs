using SavvyDB.Models;
namespace SavvyDB.Repos

{
    public interface IManagerRepo
    {
         void AddManager(Managers Manager);
         Managers GetManager(int id);
         void UpdateManager(Managers Manager);
         void DeleteManager(Managers Manager);
    }
}