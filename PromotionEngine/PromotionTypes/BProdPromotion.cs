using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionTypes
{
    //Product pack "B", which can be extended in future with any implementation we want.
    public class BProdPromotion: IProductPack
    {
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }


        //Promotion type => [2 of B's for 45]
        public decimal GetTotalPrice() => SKUID.BPromotionPrice * (ProductCount / 2) + ProductPrice * (ProductCount % 2);
    }
}
