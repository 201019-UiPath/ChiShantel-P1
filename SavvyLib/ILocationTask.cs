using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyLib
{
    public interface ILocationTask
    {
        public void AddLocation(Location Location);

        public Location GetLocation(int id);

        public void UpdateLocation(Location Location);

        public List<Location> GetAllLocations();
    }
}