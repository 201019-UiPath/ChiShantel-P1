using SavvyDB;
using System.Collections.Generic;
using SavvyDB.Models;
using System;

namespace SavvyLib
{
    public class LocationTask
    {
        private ILocationRepo repo;
        public LocationTask(ILocationRepo repo)
        {
            this.repo = repo;
        }

         /*public void AddLocation(Location Location)
         {
            repo.AddLocation(Location);
         }
        */
        /*public List<Location> GetLocations()
        {
            List<Location> locations = repo.GetLocations();
            return locations;
        }*/
    }
}