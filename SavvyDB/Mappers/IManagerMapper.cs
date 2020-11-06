using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface IManagerMapper
    {
         Managers ParseManager(Manager Manager);
         Manager ParseManager(Managers Manager);
         ICollection<Manager> ParseManager(ICollection<Managers> Manager);
         ICollection<Managers> ParseManager(ICollection<Manager> Manager);
         List<Manager> ParseManager(List<Managers> Manager);
         List<Managers> ParseManager(List<Manager> Manager);
    }
}