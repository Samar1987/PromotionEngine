
namespace PromotionEngine.Products
{
    public class AProductPack: IProductPack
    {
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }

        public decimal GetTotalPrice() => ProductCount * ProductPrice;
    }
}
