using System;
using SavvyDB;
using SavvyDB.Mappers;
using SavvyDB.Entities;
using SavvyDB.Models;
using SavvyLib;
using Serilog;

namespace SavvyUI
{
    public class CustomerMenu
    {
        private string userInput;
        private int productID;
        private SavvyRepo savvyRepo;
        private SavvyContext context;
        private LocationTask locationtask;
        private InventoryTask inventorytask;
        private ProductTask producttask;
        private ProductMenu productMenu;
        private CartMenu cartMenu;
        private Customer customer;

        public CustomerMenu(SavvyContext context)
        {
            this.context = context;
            productMenu = new ProductMenu(context, customer);
            cartMenu = new CartMenu(context);
        }
        public void start()
        {
            
            do 
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[1] Buy a Product");
                Console.WriteLine("[2] Check Order History");
                Console.WriteLine("[3] View Cart/Check Out");
                Console.WriteLine("[4] Check Location Inventory");
                Console.WriteLine("[5] Go back");
                userInput = Console.ReadLine();
                savvyRepo = new SavvyRepo(new SavvyContext(), new DBMapper());
                locationtask = new LocationTask(savvyRepo);
                CustomerTask customerTask = new CustomerTask(savvyRepo);
                switch (userInput) 
                {
                    case "1":
                        
                        productMenu.start();
                        Log.Information("Cart Added!");
                        break;
                    case "2":  
                        //OrderHistoryMenu.start();
                        Log.Information("Cart History Viewed!");
                        break;
                    case "3":
                        cartMenu.start();
                        break;
                    case "4":
                        Console.WriteLine("Nothing yet!");
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
            while (!userInput.Equals("4"));
        }
    }
}
