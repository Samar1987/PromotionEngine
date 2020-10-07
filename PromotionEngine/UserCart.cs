﻿using PromotionEngine.Entities;
using PromotionEngine.Service;
using System;

namespace PromotionEngine
{
    // User interface (consumer class) need to be interacted by end user to avail services from Promotion Engine app's ICartService. 
    public class UserCart
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total number of order(s)");
            int totalOreder = Convert.ToInt32(Console.ReadLine());


            // [Interface Repository pattern]
            ICartService _cart = new CartService();

            for (int i = 0; i < totalOreder; i++)
            {
                Console.WriteLine("Enter the product type");
                string productType = Console.ReadLine();
               
                Product prod = new Product { Id = productType };
                _cart.AddProduct(prod);
            }


            decimal totalPrice = _cart.GetWholeOrderTotalPrice();
            Console.WriteLine("=========================================");
            Console.WriteLine("Your Total Order Value: {0}", totalPrice);
            Console.ReadLine();
        }
    }
}