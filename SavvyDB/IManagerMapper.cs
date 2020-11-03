using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB
{
    public interface IManagerMapper
    {
         Managers ParseManager(Manager Manager);

         Manager ParseManager(Managers Manager);

         ICollection<Managers> ParseManager(List<Manager> Manager);

         List<Manager> ParseManager(ICollection<Managers> Manager);
    }
}