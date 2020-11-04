using System;
using Serilog;

namespace SavvyUI

{
    public class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File("../SavvyUI/Logtxt.txt")
            .CreateLogger();
            Menu mainMenu = new MainMenu();
            mainMenu.start();
        }

    }
}
