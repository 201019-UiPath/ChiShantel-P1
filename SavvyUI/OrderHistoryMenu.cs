namespace SavvyUI
{
    public class OrderHistoryMenu
    {
        void start(){
            List<Cart> carthistory = GetOrderHistory();
                foreach (Cart cartitem in carthistory)
                    {
                        Console.WriteLine("CustomerID: " + cartitem.Custid);
                        Console.WriteLine("ProductID: " + cartitem.Productid);
                        Console.WriteLine("LocationID: "+ cartitem.Locationid);
                        Console.WriteLine("Quantity: " + cartitem.Quantity + "\n");
                    }
    }
}