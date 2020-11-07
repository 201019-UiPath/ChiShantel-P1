using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface IManagerMapper
    {
         Managers ParseManager(Manager Manager);
         Manager ParseManager(Managers Manager);
         ICollection<Manager> ParseManager(List<Managers> Manager);
         List<Managers> ParseManager(ICollection<Manager> Manager);

    }
}