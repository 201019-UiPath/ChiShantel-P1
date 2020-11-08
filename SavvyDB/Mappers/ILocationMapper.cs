using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface ILocationMapper
    {
         Locations ParseLocation(Location Location);
         Location ParseLocation(Locations Location);
         List<Location> ParseLocation(ICollection<Locations> Location);
         ICollection<Locations> ParseLocation(List<Location> Location);
    }
}