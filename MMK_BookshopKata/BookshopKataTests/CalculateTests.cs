using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BookshopKata;

namespace BookshopKataTests
{
    [TestClass]
    public class CalculateTests
    {
        [TestMethod]
        public void OneBook_CalculatesCorrect()
        {
            var dict = new Dictionary<string, int>();
            dict.Add("1", 1);

            var result = Bookshop.Calculate(new Basket(dict));

            Assert.AreEqual(8.0m, result);
       }

        [TestMethod]
        public void TwoSameBooks_CalculatesCorrect()
        {
            var dict = new Dictionary<string, int>();
            dict.Add("1", 2);
            
            var result = Bookshop.Calculate(new Basket(dict));

            Assert.AreEqual(16.0m, result);
        }
        [TestMethod]
        public void TwoDifferentBooks_CalculatesCorrectDiscount()
        {
            var dict = new Dictionary<string, int>();
            dict.Add("1", 1);
            dict.Add("2", 1);

            var result = Bookshop.Calculate(new Basket(dict));

            Assert.AreEqual(15.2m, result);
        }
        [TestMethod]
        public void ThreeDifferentBooks_CalculatesCorrectDiscount()
        {
            var dict = new Dictionary<string, int>();
            dict.Add("1", 1);
            dict.Add("2", 1);
            dict.Add("3", 1);

            var result = Bookshop.Calculate(new Basket(dict));

            Assert.AreEqual(21.6m, result);
        }
        [TestMethod]
        public void ComplexScenario1_CalculatesCorrectDiscount()
        {
            var dict = new Dictionary<string, int>();
            dict.Add("2", 2);
            dict.Add("1", 2);
            dict.Add("3", 1);

            var result = Bookshop.Calculate(new Basket(dict));

            Assert.AreEqual(36.8m, result);
        }
        [TestMethod]
        public void ComplexScenario2_CalculatesCorrectDiscount()
        {
            var dict = new Dictionary<string, int>();
            dict.Add("2", 2);
            dict.Add("1", 2);
            dict.Add("3", 2);
            dict.Add("4", 1);
            dict.Add("5", 1);

            var result = Bookshop.Calculate(new Basket(dict));

            Assert.AreEqual(51.2m, result);
        }
    }
}
