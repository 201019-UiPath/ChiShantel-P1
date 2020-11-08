using SavvyDB;
using SavvyDB.Models;
namespace SavvyLib

{
    public class LocationTask
    {
        private SavvyRepo repo;
        public LocationTask(SavvyRepo repo)
        {
            this.repo = repo;
        }

        public void AddLocation(Location Location)
        {
            repo.AddLocation(Location);
        }
        public void GetLocation(int id)
        {
            repo.GetLocation(id);
        }
        public void GetAllLocations()
        {
            repo.GetAllLocations();
        }
        public void UpdateLocation(Location Location)
        {
            repo.AddLocation(Location);
        }
    }
}