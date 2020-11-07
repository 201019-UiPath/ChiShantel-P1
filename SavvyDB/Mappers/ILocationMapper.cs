using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface ILocationMapper
    {
         Locations ParseLocation(Location Location);
         Location ParseLocation(Locations Location);
         List<Locations> ParseLocation(ICollection<Location> Location);
         ICollection<Location> ParseLocation(List<Locations> Location);
    }
}