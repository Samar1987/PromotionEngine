
namespace PromotionEngine.Products
{
    public class AProductPack: IProductPack
    {
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }

        // This method [logic] can be changed for this product in future as per the business requirment.
        public decimal GetTotalPrice() => ProductCount * ProductPrice;
    }
}
