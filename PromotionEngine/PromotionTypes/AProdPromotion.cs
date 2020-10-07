using PromotionEngine.Entities;

namespace PromotionEngine.PromotionTypes
{
    //Product pack "A", which can be extended in future with any implementation we want.
    public class AProdPromotion: IProductPack
    {
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }


        //Promotion type => [3 of A's for 130] 
        public decimal GetTotalPrice() => SKUID.APromotionPrice * (ProductCount / 3) + ProductPrice * (ProductCount % 3);
    }
}
