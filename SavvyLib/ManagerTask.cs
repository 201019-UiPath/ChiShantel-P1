using SavvyDB.Models;
using SavvyDB;


namespace SavvyLib
{
    public class ManagerTask
    {
        private SavvyRepo repo;

        public ManagerTask(SavvyRepo repo)
        {
            this.repo = repo;
        }
        public void AddManager(Manager Manager)
        {
            repo.AddManager(Manager);
        }
        public void GetManager(int id)
        {
            repo.GetManager(id);
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