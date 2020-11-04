using System;
using SavvyDB;
using SavvyDB.Models;
using SavvyDB.Entities;
using System.Collections.Generic;

namespace SavvyUI
{
    public class customerMenu
    {
        private string userInput;
        private int count = 1;
        private int custID = 1;
        private int productID;
        private List<Location> location;
        private List<SavvyDB.Models.Inventory> product;
        private SavvyRepo savvyRepo;
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
                savvyRepo = new SavvyRepo(new SavvyContext(), new DBMapper()); 
                switch (userInput) 
                {
                    case "1":
                        Console.WriteLine("Select a location!");
                        location = savvyRepo.GetLocations();
                        count = 1;
                        foreach (Location singleLocation in location) 
                        { 
                            Console.WriteLine("[" + count + "]");
                            Console.WriteLine(singleLocation.Name);
                            count ++;
                        }
                        userInput = Console.ReadLine();

                        Console.WriteLine("Getting items...");

                        List<SavvyDB.Entities.Inventory> product = savvyRepo.GetProducts(Int32.Parse(userInput));
                        foreach (SavvyDB.Entities.Inventory singleProduct in product)
                        {
                            Console.WriteLine("Item ID: " + singleProduct.Productid);
                        }

                        Console.WriteLine ("Select a product!");
                        userInput = Console.ReadLine();
                        //savvyRepo.AddProduct(userInput);
                        Console.WriteLine("How many of this product do you wish to purchase?");
                        userInput = Console.ReadLine();

                       // cart = savvyRepo.AddToCart(cart);

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
