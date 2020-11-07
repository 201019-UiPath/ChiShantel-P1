using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface IProductMapper
    {
         SavvyDB.Entities.Products ParseProduct(SavvyDB.Models.Products Products);
         SavvyDB.Models.Products ParseProduct(SavvyDB.Entities.Products Products);
         ICollection<SavvyDB.Entities.Products> ParseProduct(List<SavvyDB.Models.Products> Product);
         List<SavvyDB.Models.Products> ParseProduct(ICollection<SavvyDB.Entities.Products> Product);
         
    }
}