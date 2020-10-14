using PromotionEngine.Products;
using PromotionEngine.PromotionTypes;

namespace PromotionEngine
{
    public class ProductFactory
    {
        public static IProductPack GetProductPack(string SkuId) 
        {
            IProductPack prodPack = null;
            switch (SkuId) 
            {
                case "A":
                    prodPack = new AProdPromotion();
                    break;
                case "B":
                    prodPack = new BProdPromotion();
                    break;
                case "C":
                    prodPack = new CProductPack();
                    break;
                case "D":
                    prodPack = new DProductPack();
                    break;
            }

            return prodPack;
        }
    }
}
