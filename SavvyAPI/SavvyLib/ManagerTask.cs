using SavvyDB.Models;
using SavvyDB;


namespace SavvyLib
{
    public class ManagerTask
    {
        private IManagerRepo repo;

        public ManagerTask(IManagerRepo repo)
        {
            this.repo = repo;
        }
        public void AddManager(Manager Manager)
        {
            repo.AddManager(Manager);
        }
        public Manager GetManager(int id)
        {
            return repo.GetManager(id);
        }
        public void UpdateManager(Manager Manager)
        {
            repo.UpdateManager(Manager);
        }
        public void RemoveManager(Manager Manager)
        {
            repo.DeleteManager(Manager);
        }
    }
}