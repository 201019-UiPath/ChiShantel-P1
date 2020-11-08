using SavvyDB;
using SavvyDB.Models;
using System.Collections.Generic;
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
        public Location GetLocation(int id)
        {
            return repo.GetLocation(id);
        }
        public List<Location> GetAllLocations()
        {
            return repo.GetAllLocations();
        }
        public void UpdateLocation(Location Location)
        {
            repo.AddLocation(Location);
        }
    }
}