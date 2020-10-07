using System;
using System.Linq;

namespace PromotionEngine.Entities
{
    public static class SKUID
    {
        public static string[] SKUIDs = new string[] { "A", "B", "C", "D" };

        public static decimal APromotionPrice = 130m;
        public static decimal BPromotionPrice = 45m;
        public static decimal CDPromotionPrice = 30m;
        public static bool CheckSkuId(string skuId) => SKUIDs.Contains(skuId);
    }
}
