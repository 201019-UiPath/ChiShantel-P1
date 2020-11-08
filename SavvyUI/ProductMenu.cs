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
        private SavvyRepo savvyRepo;
        private Product product;
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
            List<Location> Location = savvyRepo.GetAllLocations();
            CartTask cartTask = new CartTask(savvyRepo);
            CartItemTask cartitemtask = new CartItemTask(savvyRepo);
            Cart cart = new Cart();
            count = 1;
            foreach (Location singleLocation in Location) 
                { 
                    Console.WriteLine("[" + count + "]");
                    Console.WriteLine(singleLocation.Name);
                    count ++;
                }
                userInput = Console.ReadLine();
                int Locationid = Int32.Parse(userInput);
                InventoryTask inventorytask = new InventoryTask(savvyRepo);

                Console.WriteLine("Getting items...");
                List<Inventory> Items = inventorytask.GetInventory(Locationid);
                foreach (Inventory Item in Items)
                    {
                        int id = Item.ProductId;
                        Product prod = producttask.GetProduct(id);
                        Console.WriteLine("Product ID: " + prod.ProductId);
                        Console.WriteLine("Item Name: " + prod.Name);
                        Console.WriteLine("Cost: " + prod.Cost);
                    }

                        Console.WriteLine ("Select a product (By ID!)");
                        userInput = Console.ReadLine();
                        Product chosenproduct = producttask.GetProduct(Int32.Parse(userInput));
                        CartItem cartitem = new CartItem();
                        cartitem.ProductId = chosenproduct.ProductId;
                        cartitem.CartId = cart.CartId;
                        cartitemtask.AddCartItem(cartitem); 
        }
    }
}