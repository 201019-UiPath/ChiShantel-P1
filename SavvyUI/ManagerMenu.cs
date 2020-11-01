using System;
//using SavvyLib;
//using SavvyDB;
using System.Collections.Generic;

namespace SavvyUI
{
    public class managerMenu
    {
        private string userInput;
        //private ManagerRepo managerRepo;
        public managerMenu()
        {
            
        }
        public void start()
        {
            do 
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[1] Add Location");
                Console.WriteLine("[2] Check Inventory");
                Console.WriteLine("[3] Check Order History");
                Console.WriteLine("[4] Replenish Inventory");
                Console.WriteLine("[5] Go back");
                userInput = Console.ReadLine();
                switch (userInput) 
                {
                    case "1":
                        //Add Location
                        break;
                    case "2":  
                        //Select Location 
                        //Pulls up inventory
                        break;
                    case "3":
                       //Select location 
                       //Pulls up location inventory           
                        break;
                    case "4":
                        //Select location
                        //Add item or select existing item
                        //Add number to add to inventory 
                        break;
                    case "5":
                        Console.WriteLine("Returning to main menu...");
                        break;
                    default:
                        //invalid input message;
                        Console.WriteLine("Make a valid selection!");
                        break;
                    }
            }
            while (!userInput.Equals("5"));
        }
    }
}
