using SavvyDB;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyLib

{
    public class LocationTask : ILocationTask
    {
        private ILocationRepo repo;
        public LocationTask(ILocationRepo repo)
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