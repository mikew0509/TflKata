using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshopKata
{
    public static class RecursiveCalculator
    {

        public static decimal CalculateWithDiscount(Basket basket)
        {
            if (basket.Count == 0)
            {
                return 0m;
            }
            var cost = ApplyHighestDiscount(ref basket);
            return cost + CalculateWithDiscount(basket);
        }

        private static decimal ApplyHighestDiscount(ref Basket basket)
        {
            var level = basket.Distinct;
            var discount = Bookshop.GetDiscountForLevel(level);
            basket.RemoveDistinctLevel();

            var cost = level * Bookshop.Price * (1 - discount);

            return cost;

        }
    }
}
