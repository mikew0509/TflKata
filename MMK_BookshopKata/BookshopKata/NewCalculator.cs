using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshopKata
{
    public static class NewCalculator
    {
        public static decimal CalculateWithDiscount(Basket basket)
        {
            var maxLevel = basket.Distinct;
            var bestPrice = basket.Count * Bookshop.Price;
            var bestLevel = 1;
            for (int level = 1; level <= maxLevel; level++)
            {
                var price = CalculateDiscountAtLevel(level);
                if (price < bestPrice)
                {
                    bestPrice = price;
                    bestLevel = level;
                }
            }

            return bestPrice;
        }

        private static decimal CalculateDiscountAtLevel(int level)
        {
            var discount = Bookshop.GetDiscountForLevel(level);
            var cost = level * Bookshop.Price * (1 - discount);

            return cost;
        }
    }
}
