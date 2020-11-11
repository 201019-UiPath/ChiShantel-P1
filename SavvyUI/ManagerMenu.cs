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
        private string locationstring;
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
                Console.WriteLine("Select a location!");
                List<Location> Location = locationtask.GetAllLocations();
                count = 1;
                foreach (Location singlelocation in Location)
                    {
                        Console.WriteLine("[" + count + "]");
                        Console.WriteLine(singlelocation.Name);
                        count ++;
                    }
                locationstring = Console.ReadLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[1] Check Inventory");
                Console.WriteLine("[2] Replenish Inventory");
                Console.WriteLine("[3] Go Back");
                userInput = Console.ReadLine();
                int Locationid = Int32.Parse(locationstring);
                List<Inventory> Items = inventorytask.GetInventoryByLocation(Locationid);
                switch (userInput) 
                {
                    case "1":
                        //Pulls up inventory for selected location
                        
                        Console.WriteLine("Getting items...");
                        foreach (Inventory Item in Items)
                            {
                                int id = Item.ProductId;
                                Product prod = producttask.GetProduct(id);
                                Console.WriteLine("Product ID: " + id);
                                Console.WriteLine("Item Name: " + prod.Name);
                                Console.WriteLine("Quantity: "+ Item.Quantity);
                                Console.WriteLine (" ");
                            }
                        break;
                    case "2":  
                        //Replenishes inventory
                        Console.WriteLine("Getting items...");
                        foreach (Inventory Item in Items)
                            {
                                int id = Item.ProductId;
                                Product prod = producttask.GetProduct(id);
                                Console.WriteLine("Product ID: " + id);
                                Console.WriteLine("Item Name: " + prod.Name);
                                Console.WriteLine("Quantity: "+ Item.Quantity);
                                Console.WriteLine (" ");
                            }
                        Console.WriteLine("Select an item (by ID)");
                        userInput = Console.ReadLine();
                        List<Inventory> inv = inventorytask.GetInventoryByLocation(Locationid);
                        Console.WriteLine("How much of this item is now in stock?");
                        string newquantity = Console.ReadLine();
                        foreach (Inventory item in inv)
                        {
                            if (item.ProductId == Int32.Parse(userInput))
                            {
                                
                                Inventory updatedinv = inventorytask.GetInventory(item.InventoryId);
                                updatedinv.Quantity = Int32.Parse(newquantity);
                                inventorytask.UpdateInventory(updatedinv);
                                Console.WriteLine("Item has been restocked!");
                            }
                        }
                        
                        
                        
                        
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
