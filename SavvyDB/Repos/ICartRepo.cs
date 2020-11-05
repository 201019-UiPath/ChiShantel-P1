using SavvyDB.Models;
namespace SavvyDB
{
    public interface ICartRepo
    {
        void AddToCart(Cart Cart);
    }
}