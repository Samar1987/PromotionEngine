using PromotionEngine.Entities;

namespace PromotionEngine.PromotionTypes
{
    //Product pack "CD", which can be extended in future with any implementation we want.
    public class CDProdPromotion: IProductPack
    {
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }

        //This class own properties.
        public int CProductCount { get; set; }
        public decimal CProductPrice { get; set; }
        public int DProductCount { get; set; }
        public decimal DProductPrice { get; set; }


        //Promotion type => [C & D for 30] 
        public decimal GetTotalPrice()
        {
            int ProdCount = CProductCount > DProductCount ? DProductCount : CProductCount;
            return (ProdCount * SKUID.CDPromotionPrice) + ((CProductCount - ProdCount) * CProductPrice) + ((DProductCount - ProdCount) * DProductPrice);
        }
    }
}
