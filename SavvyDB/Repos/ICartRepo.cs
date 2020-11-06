using SavvyDB.Models;
namespace SavvyDB.Repos

{
    public interface ICartRepo
    {
        void AddCart(Cart Cart);
        void UpdateCart(Cart Cart);
        Cart GetCart(int id);
        void DeleteCart(Cart Cart);
    }
}