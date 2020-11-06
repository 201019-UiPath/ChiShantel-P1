using System.Collections.Generic;
namespace SavvyDB.Mappers
{
    public interface IOrderItemMapper
    {
         SavvyDB.Entities.OrderItem ParseOrderItem(SavvyDB.Models.OrderItem OrderItem);
         SavvyDB.Models.OrderItem ParseOrderItem(SavvyDB.Entities.OrderItem OrderItem);
         ICollection<SavvyDB.Models.OrderItem> ParseOrderItem(ICollection<SavvyDB.Entities.OrderItem> OrderItem);
         ICollection<SavvyDB.Entities.OrderItem> ParseOrderItem(ICollection<SavvyDB.Models.OrderItem> OrderItem);
         List<SavvyDB.Entities.OrderItem> ParseOrderItem(List<SavvyDB.Models.OrderItem> OrderItem);
         List<SavvyDB.Models.OrderItem> ParseOrderItem(List<SavvyDB.Entities.OrderItem> OrderItem);
    }
}