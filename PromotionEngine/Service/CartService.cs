using System.Linq;
using System.Collections.Generic;
using PromotionEngine.Entities;
using PromotionEngine.Products;
using PromotionEngine.PromotionTypes;
using System.Reflection.PortableExecutable;

namespace PromotionEngine.Service
{
    //This "Cart Service" handles the adding of products to order list and calculating the whole order's value. 
    public class CartService: ICartService
    {
        //In future, we can add new product pack AND\OR promotion type here based on business need.
        IProductPack APromoPack;
        IProductPack BPromoPack;
        IProductPack CPack;
        IProductPack DPack;

        public CartService()
        {
            // Loosly coupled product modules/classes as here is no "new" keyword to create module/class object.
            APromoPack = ProductFactory.GetProductPack("A");
            BPromoPack = ProductFactory.GetProductPack("B");
            CPack = ProductFactory.GetProductPack("C");
            DPack = ProductFactory.GetProductPack("D");
        }

        //Adding the products to order list with their Count and Price values, based upon SKU Id value.
        public void AddProduct(Product prod)
        {
            switch (prod.Id)
            {
                case "A":                    
                    APromoPack.ProductCount++;
                    APromoPack.ProductPrice = 50m;
                    break;
                case "B":                    
                    BPromoPack.ProductCount++;
                    BPromoPack.ProductPrice = 30m;
                    break;
                case "C":
                    CPack.ProductCount++;
                    CPack.ProductPrice = 20m;
                    break;
                case "D":
                    DPack.ProductCount++;
                    DPack.ProductPrice = 15m;
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
