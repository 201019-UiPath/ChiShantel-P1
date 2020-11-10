using System;
using SavvyDB;
using System.Collections.Generic;
using SavvyDB.Entities;
using SavvyDB.Models;
using SavvyLib;
using Serilog;

namespace SavvyUI
{
    public class ManagerMenu
    {
        private string userInput;
        private int productID;
        private int count;
        private SavvyRepo repo;
        private LocationTask locationtask;
        private InventoryTask inventorytask;
        private ProductTask producttask;
        private ProductMenu productMenu;
        private OrderTask ordertask;
        private OrderItemTask orderitemtask;

        private Customer customer;

        public ManagerMenu(SavvyRepo repo)
        {
            this.repo = repo;
            this.locationtask = new LocationTask(repo);
            this.inventorytask = new InventoryTask(repo);
            this.producttask = new ProductTask(repo);
            this.ordertask = new OrderTask(repo);
            this.orderitemtask = new OrderItemTask(repo);
        }
        public void start()
        {
            do 
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[1] Check Inventory");
                Console.WriteLine("[2] Replenish Inventory");
                Console.WriteLine("[3] Go Back");
                userInput = Console.ReadLine();
                switch (userInput) 
                {
                    case "1":
                        //Select location and pulls up inventory
                        Console.WriteLine("Select a location!");
                        List<Location> Location = locationtask.GetAllLocations();
                        count = 1;
                        foreach (Location singlelocation in Location)
                        {
                            Console.WriteLine("[" + count + "]");
                            Console.WriteLine(singlelocation.Name);
                            count ++;
                        }
                        userInput = Console.ReadLine();
                        int Locationid = Int32.Parse(userInput);
                        Console.WriteLine("Getting items...");
                        List<Inventory> Items = inventorytask.GetInventory(Locationid);
                        foreach (Inventory Item in Items)
                            {
                                int id = Item.ProductId;
                                Product prod = producttask.GetProduct(id);
                                Console.WriteLine("Product ID: " + id);
                                Console.WriteLine("Item Name: " + prod.Name);
                                Console.WriteLine("Cost: " + prod.Cost);
                                Console.WriteLine("Quantity: "+ Item.Quantity);
                                Console.WriteLine (" ");
                            }
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
            while (!userInput.Equals("3"));
        }
    }
}
