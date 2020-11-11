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
        Customer customer;
        private SavvyRepo repo;
        private LocationTask locationtask;
        private ProductMenu productMenu;
        private OrderHistoryMenu orderhistorymenu;
        private CartMenu cartMenu;

        public CustomerMenu(SavvyContext context, DBMapper mapper)
        {
            this.repo = new SavvyRepo(context, mapper);
            productMenu = new ProductMenu(context, mapper, customer);
            cartMenu = new CartMenu();
            //orderhistorymenu = new OrderHistoryMenu(context, mapper);
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
                locationtask = new LocationTask(repo);
                CustomerTask customerTask = new CustomerTask(repo);
                switch (userInput) 
                {
                    case "1":
                        
                        productMenu.start();
                        Log.Information("Cart Added!");
                        break;
                    case "2":  
                        orderhistorymenu.start();
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
            while (!userInput.Equals("5"));
        }
    }
}
