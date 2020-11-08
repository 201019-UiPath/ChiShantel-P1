using System;
using SavvyDB;
using SavvyDB.Entities;
using SavvyDB.Models;
using SavvyLib;
using System.Collections.Generic;
using SavvyDB.Mappers;

namespace SavvyUI
{
    public class ProductMenu
    {
        private string userInput;
        private Product product;
        SavvyRepo savvyrepo = new SavvyRepo(new SavvyContext(), new DBMapper());
        private CartTask carttask;
        private CustomerTask customertask;
        private InventoryTask inventorytask;
        private CartItemTask cartitemtask;
        private LocationTask locationtask;
        private ProductTask producttask;
        private SavvyContext context;
        int count;


        public ProductMenu(SavvyContext savvycontext)
        {
            this.context = savvycontext;
            
        }
        
        public void start()
        {
            Console.WriteLine("Select a location!");
            LocationTask locationtask = new LocationTask(savvyrepo);
            List<Location> Location = locationtask.GetAllLocations();
            CartTask cartTask = new CartTask(savvyrepo);
            CartItemTask cartitemtask = new CartItemTask(savvyrepo);
            ProductTask producttask = new ProductTask(savvyrepo);
            count = 1;
            foreach (Location singleLocation in Location) 
                { 
                    Console.WriteLine("[" + count + "]");
                    Console.WriteLine(singleLocation.Name);
                    count ++;
                }
                userInput = Console.ReadLine();
                int Locationid = Int32.Parse(userInput);
                InventoryTask inventorytask = new InventoryTask(savvyrepo);

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

                        Console.WriteLine ("Select a product (By ID!)");
                        userInput = Console.ReadLine();
                        Product chosenproduct = producttask.GetProduct(Int32.Parse(userInput));
                        CartItem cartitem = new CartItem();
                        cartitem.ProductId = Int32.Parse(userInput);
                        cartitem.CartId = 1;
                        Console.WriteLine("How many do you want to buy?");
                        string input = Console.ReadLine();
                        cartitem.Quantity = Int32.Parse(input);
                        cartitemtask.AddCartItem(cartitem); 
                        Console.WriteLine("Item has been added!");
        }
    }
}