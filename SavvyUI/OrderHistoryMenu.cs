using System;
using SavvyDB;
using SavvyDB.Entities;
using SavvyDB.Mappers;
using SavvyDB.Models;
using SavvyLib;

namespace SavvyUI
{
    public class OrderHistoryMenu
    {
        private string userInput;
        private Product product;
        SavvyRepo repo;
        private CartTask carttask;
        Customer customer;
        private CustomerTask customertask;
        private InventoryTask inventorytask;
        private CartItemTask cartitemtask;
        private OrderTask ordertask;
        private OrderItemTask orderitemtask;
        private ProductTask producttask;
        private LocationTask locationtask;
        public OrderHistoryMenu(SavvyContext context, DBMapper mapper)
        {
            this.repo = new SavvyRepo(context, mapper);
            this.locationtask = new LocationTask(repo);
            this.inventorytask = new InventoryTask(repo);
            this.producttask = new ProductTask(repo);
            this.ordertask = new OrderTask(repo);
            this.orderitemtask = new OrderItemTask(repo);
            this.customertask = new CustomerTask(repo);
            
        }
        public void start(){
            OrderTask ordertask = new OrderTask(repo);
            Customer customer = customertask.GetCustomer(1);

            Console.WriteLine("How would you like to search for your order history?");
            Console.WriteLine("[1] By Order Date (Ascending)");
            Console.WriteLine("[2] By Order Date (Descending)");
            Console.WriteLine("[3] By Price (Ascending)");
            Console.WriteLine("[4] By Price (Descending)");
            Console.WriteLine("[5] Go Back");
            userInput = Console.ReadLine();

            do  
                { 
                switch (userInput)
                {
                    case "1":
                        
                        ordertask.GetOrderFirst(DateTime.Now);
                        break;

                    case "2":

                        ordertask.GetOrderLast(DateTime.Now);
                        break;

                    case "3":

                        ordertask.GetOrderCheap(customer);
                        break;
                    case "4":

                        ordertask.GetOrderExpensive(customer);
                        break;
                }
            }
            while (!userInput.Equals("5"));
        }
    }
}
