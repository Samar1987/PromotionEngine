using System;
using System.Collections.Generic;
using PromotionEngine.Entities;

namespace PromotionEngine.Service
{
    //This "Cart Service" handles the adding of products to order list and calculating the whole order's value. 
    public class CartService: ICartService
    {

        //Adding the products to order list with their Count and Price values, based upon SKU Id value.
        public void AddProduct(Product prod)
        {
            switch (prod.Id)
            {
                case "A":                  
                    break;
                case "B":                   
                    break;
                case "C":                    
                    break;
                case "D":                    
                    break;
            };
        }


        //Calculating the total order's values "after" applying the 2 promotion types.
        //First,  promotion type => [3 of A's for 130] 
        //Second, promotion type => [2 of B's for 45]
        public decimal GetWholeOrderTotalPrice()
        {
            IEnumerable<IProductPack> packs = new List<IProductPack>() { APromoPack, BPromoPack, CPack, DPack };
            decimal totalPrice = packs.Sum(p => p.GetTotalPrice());
            return totalPrice;
        }
    }
}
