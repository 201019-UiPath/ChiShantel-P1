using System;
using SavvyDB;
using SavvyDB.Entities;
using SavvyDB.Models;
using SavvyLib;
using System.Collections.Generic;


namespace SavvyUI
{
    public class ProductMenu
    {
        private string userInput;
        private Product product;
        SavvyRepo repo;
        private Customer Customer;
        private CustomerTask customertask;
        private InventoryTask inventorytask;
        private CartItemTask cartitemtask;
        private LocationTask locationtask;
        private ProductTask producttask;
        private SavvyContext context;
        int count;


        public ProductMenu(SavvyRepo repo, Customer Customer)
        {
            this.repo = repo;
            this.Customer = Customer;
        }
        
        public void start()
        {
            Console.WriteLine("Select a location!");
            LocationTask locationtask = new LocationTask(repo);
            List<Location> Location = locationtask.GetAllLocations();
            CartTask cartTask = new CartTask(repo);
            CartItemTask cartitemtask = new CartItemTask(repo);
            ProductTask producttask = new ProductTask(repo);
            Cart cart = cartTask.GetCartByCustomer(1);

            count = 1;
            foreach (Location singleLocation in Location) 
                { 
                    Console.WriteLine("[" + count + "]");
                    Console.WriteLine(singleLocation.Name);
                    count ++;
                }
            userInput = Console.ReadLine();
            int Locationid = Int32.Parse(userInput);
            InventoryTask inventorytask = new InventoryTask(repo);

            Console.WriteLine("Getting items...");
            List<Inventory> Items = inventorytask.GetInventory(Locationid);
            string continueloop = "y";
            while (continueloop == "y")
            {
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

                    Console.WriteLine ("Select a product (By ID!)");
                    userInput = Console.ReadLine();
                    Product chosenproduct = producttask.GetProduct(Int32.Parse(userInput));
                    CartItem cartitem = new CartItem();
                    cartitem.ProductId = Int32.Parse(userInput);
                    Console.WriteLine("How many do you want to buy?");
                    string input = Console.ReadLine();
                    cartitem.CartId = 1;
                    cartitem.Quantity = Int32.Parse(input);
                    cartitemtask.UpdateCartItem(cartitem); 
                    Console.WriteLine("Item has been added!");
                    Console.WriteLine ("Keep adding to cart? (y/n)");
                    continueloop = Console.ReadLine();
            }
        }
    }
}