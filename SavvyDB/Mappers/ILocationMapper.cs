using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface ILocationMapper
    {
         Locations ParseLocation(Location Location);
         Location ParseLocation(Locations Location);
         ICollection<Location> ParseLocation(ICollection<Locations> Location);
         ICollection<Locations> ParseLocation(ICollection<Location> Location);
         List<Location> ParseLocation(List<Locations> Location);
         List<Locations> ParseLocation(List<Location> Location);
    }
}