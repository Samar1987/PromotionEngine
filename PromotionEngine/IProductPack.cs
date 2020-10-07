
namespace PromotionEngine
{
    // [Interface to implement (Composit Pattern).]
    public interface IProductPack
    {
        int ProductCount { get; set; }
        decimal ProductPrice { get; set; }
        decimal GetTotalPrice();
    }
}
