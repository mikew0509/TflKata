using System;
using System.Collections.Generic;
using System.Linq;

namespace BookshopKata
{
    public class Basket
    {
        private Dictionary<string, int> dict;

        public Basket(Dictionary<string, int> dict)
        {
            this.dict = dict;
        }

        public int Count { get { var count = 0; foreach (var key in dict.Keys) { count += dict[key]; } return count; } }

        public int Distinct { get { return dict.Keys.ToList().Count(x => dict[x] > 0); } }

        public void RemoveDistinctLevel()
        {
            foreach (var key in dict.Keys.ToList().Where(x => dict[x] > 0))
                dict[key]--;
        }
    }
}