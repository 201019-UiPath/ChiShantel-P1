// using System;
// using SavvyDB;
// using SavvyDB.Entities;
// using SavvyDB.Models;
// using SavvyLib;
// using System.Collections.Generic;
// using SavvyDB.Mappers;
// namespace SavvyUI
// {
//     public class OrderHistoryMenu
//     {
//         private string userInput;
//         private Product product;
//         SavvyRepo savvyrepo = new SavvyRepo(new SavvyContext(), new DBMapper());
//         private CartTask carttask;
//         private CustomerTask customertask;
//         private InventoryTask inventorytask;
//         private CartItemTask cartitemtask;
//         private LocationTask locationtask;
//         void start(){
//             CartItemTask cartitemtask = new CartItemTask(savvyrepo);
//             List<Cart> carthistory = GetOrder();
//                 foreach (Cart cartitem in carthistory)
//                     {
//                         Console.WriteLine("CustomerID: " + cartitem.Custid);
//                         Console.WriteLine("ProductID: " + cartitem.Productid);
//                         Console.WriteLine("LocationID: "+ cartitem.Locationid);
//                         Console.WriteLine("Quantity: " + cartitem.Quantity + "\n");
//                     }
//     }
// }