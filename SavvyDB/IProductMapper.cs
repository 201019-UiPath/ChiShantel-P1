using SavvyDB.Entities;
using SavvyDB.Models;
using System.Collections.Generic;
namespace SavvyDB
{
    public interface IProductMapper
    {
         SavvyDB.Entities.Products ParseProduct(SavvyDB.Models.Products Products);

         ICollection<SavvyDB.Models.Products> ParseProduct(List<SavvyDB.Entities.Products> Product);
         
         SavvyDB.Models.Products ParseProduct(SavvyDB.Entities.Products Products);

         List<SavvyDB.Entities.Products> ParseProduct(ICollection<SavvyDB.Models.Products> Product);
    }
}