using System;
using SavvyDB;
using SavvyDB.Entities;
using SavvyDB.Mappers;

namespace SavvyUI
{
    public class MainMenu
    {
        private string userInput;
        private CustomerMenu customerMenu;
        private ManagerMenu managerMenu;
        private SavvyRepo repo;
        public MainMenu(SavvyContext context, DBMapper mapper)
        {
            this.customerMenu = new CustomerMenu(context, mapper);
            this.managerMenu = new ManagerMenu(new SavvyRepo(context, mapper));
        }
        public void start()
        {
            do
            {
                Console.WriteLine("Welcome to Savvy Stationery! Select a login: ");
                Console.WriteLine("[1] Customer");
                Console.WriteLine("[2] Manager");
                Console.WriteLine("[x] Abort");
                userInput = Console.ReadLine();
                //User makes a selection
                    switch (userInput) 
                    {
                        case "1":
                            customerMenu.start();
                            break;
                        case "2":  
                            managerMenu.start();
                            break;
                        case "x":
                            Console.WriteLine("We hope to see you again!");            
                            break;
                        default:
                            //invalid input message;
                            Console.WriteLine("Make a valid selection!");
                            break;
                    }
            }
            while (!userInput.Equals("x"));
        }
    }
}
