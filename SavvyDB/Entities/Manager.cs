using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class Manager
    {
        public int Managerid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public int? Locationid { get; set; }

        public virtual Location Location { get; set; }
    }
}
