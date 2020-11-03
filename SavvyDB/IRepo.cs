using SavvyLib;
using Ststem.Collections.Generic;
namespace SavvyDB
{
    public interface IRepo
    {
        void AddProduct(Product product);
        List<Product> GetProduct;
    }
}