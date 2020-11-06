using SavvyDB.Models;
namespace SavvyDB.Repos

{
    public interface ILocationRepo
    {
        void AddLocation(Locations Location);
        Locations GetLocation(int id);
        void UpdateLocation(Locations Location);
        void DeleteLocation(Locations Location);
    }
}