
namespace PromotionEngine.Products
{
    public class CProductPack: IProductPack
    {
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }

        public decimal GetTotalPrice() => ProductCount * ProductPrice;
    }
}
