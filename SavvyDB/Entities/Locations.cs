using System;
using System.Collections.Generic;

namespace SavvyDB.Entities
{
    public partial class Locations
    {
        public Locations()
        {
            Inventories = new HashSet<Inventories>();
            Managers = new HashSet<Managers>();
        }

        public int Locationid { get; set; }
        public string Name { get; set; }
        public int Employees { get; set; }

        public virtual ICollection<Inventories> Inventories { get; set; }
        public virtual ICollection<Managers> Managers { get; set; }
    }
}
