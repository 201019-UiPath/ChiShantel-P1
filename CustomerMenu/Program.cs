using System;
using SavvyLib;
using SavvyDB;
using System.Collections.Generic;

namespace Customer
{
    public class customerMenu
    {
        private string userInput;
        //private CustomerRepo customerRepo;
        public void start()
        {
            
            do 
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[1] Buy a Product");
                Console.WriteLine("[2] Check Order History");
                Console.WriteLine("[3] Check Location Inventory");
                Console.WriteLine("[4] Go back");
                userInput = Console.ReadLine();
                switch (userInput) 
                {
                    case "1":
                        //Select Location
                        //Pull up list of available items 
                        //Select item
                        //Select quantity
                        //Add to order history
                        //Subtract item quantity from inventory from that location
                        break;
                    case "2":  
                        //Select Location
                        //Pull up order history
                        //Sort option(?)
                        break;
                    case "3":
                        //Select Location
                        //Pull up list of available items          
                        break;
                    case "4":
                        Console.WriteLine("Returning to main menu...")
                    default:
                        //invalid input message;
                        Console.WriteLine("Make a valid selection!");
                        break;
                    }
            }
            while (!userInput.Equals("4"));
    }
}
