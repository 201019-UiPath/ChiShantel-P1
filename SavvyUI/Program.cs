using SavvyDB.Entities;
using Serilog;

namespace SavvyUI

{
    public class Program
    {
        static void Main(string[] args)
        {
            SavvyContext context = new SavvyContext();
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File("Logs\\Logtxt.txt")
            .CreateLogger();
            MainMenu mainMenu = new MainMenu(context);
            mainMenu.start();
        }

    }
}
