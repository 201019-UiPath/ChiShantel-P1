using SavvyDB;
using SavvyDB.Models;
using SavvyDB.Entities;
using SavvyLib;
using System.Collections.Generic;
using System;
using Xunit;

namespace SavvyTest
{
    public class UnitTest
    {
        [Fact]
        //Checking locations are returned
        public void ActuallyGetsAllLocations()
        {
            using var test1 = new SavvyContext();
            SavvyRepo repo = new SavvyRepo(test1, new DBMapper());
            List<SavvyDB.Entities.Location> locations = repo.GetLocations();
            Assert.NotNull(locations);
            
        }
    }
}