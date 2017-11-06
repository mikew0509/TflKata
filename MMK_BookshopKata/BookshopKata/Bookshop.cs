using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshopKata
{
    public class Bookshop
    {
        public static decimal Price = 8.0m;
        static void Main(string[] args)
        {
            var dict = GetInput();
            var basket = new Basket(dict);
            var result = Calculate(basket);
            Console.ReadLine();
        }

        public static decimal Calculate(Basket basket)
        {
            //return TotalWithoutDiscount(dict);
            return RecursiveCalculator.CalculateWithDiscount(basket);
        }
        public static decimal GetDiscountForLevel(int level)
        {
            switch (level)
            {
                case 1: return 0m;
                case 2: return 0.05m;
                case 3: return 0.1m;
                case 4: return 0.2m;
                case 5: return 0.25m;
                default: return 0.25m;
            }
        }
        private static decimal TotalWithoutDiscount(Basket basket)
        {
            return basket.Count * Price;
        }
        private static Dictionary<string, int> GetInput()
        {
            string input = Console.ReadLine();
            char[] delim = { ',' };
            var keys = input.Split(delim);
            var dict = new Dictionary<string, int>();
            foreach (var key in keys)
            {
                if (dict.ContainsKey(key))
                {
                    dict[key]++;
                }
                else
                {
                    dict[key] = 1;
                }
            }

            return dict;
        }

    }
}
