using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Repos

{
    public interface ILocationRepo
    {
        void AddLocation(Location Location);
        Location GetLocation(int id);
        List<Location> GetAllLocations();
        void UpdateLocation(Location Location);
        void DeleteLocation(Location Location);
    }
}