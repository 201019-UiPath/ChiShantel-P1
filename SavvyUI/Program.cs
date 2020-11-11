using SavvyDB.Entities;
using SavvyDB.Mappers;
using SavvyDB;
using Serilog;

namespace SavvyUI

{
    public class Program
    {
        static void Main(string[] args)
        {
            SavvyContext context = new SavvyContext();
            DBMapper mapper = new DBMapper();
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File("Logs\\Logtxt.txt")
            .CreateLogger();
            MainMenu mainMenu = new MainMenu(context, mapper);
            mainMenu.start();
        }

    }
}
