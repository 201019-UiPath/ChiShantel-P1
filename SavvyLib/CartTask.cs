using SavvyDB;
using System.Collections.Generic;
using SavvyDB.Models;
using System;

namespace SavvyLib
{

    public class CartTask
    {
        private ICartRepo repo;
        public CartTask(ICartRepo repo)
        {
            this.repo = repo;
        }
        public void AddToCart(Cart cart)
        {
            repo.AddToCart(cart);
        }
    }
}