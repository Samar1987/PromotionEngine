using PromotionEngine.Entities;

namespace PromotionEngine.Service
{
    public interface ICartService
    {
        void AddProduct(Product prod);
        decimal GetWholeOrderTotalPrice();
    }
}