using SavvyDB.Repos;
namespace SavvyDB
{
    public interface IRepo : ICartItemRepo, ICartRepo, ICustomerRepo, IInventoryRepo, ILocationRepo, IManagerRepo, IOrderItemRepo, IOrderRepo, IProductsRepo
    {
        
    }
}