using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class Managers
    {
        public int Managerid { get; set; }
        public int Locationid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public virtual Locations Location { get; set; }
    }
}
