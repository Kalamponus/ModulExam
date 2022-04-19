using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BookDiscountLibrary;

namespace LibTest
{
    
    [TestClass]
    public class UnitTest1
    {
        DiscountCalc calc = new DiscountCalc();
        [TestMethod]
        public void GetSale_SmallUsualValue()
        {
            int actual, expected;
            actual = calc.Discount(100, 3);
            expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSale_BigUsualValue()
        {
            int actual, expected;
            actual = calc.Discount(5050, 3);
            expected = 15;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSale_SmallNegativeValue()
        {
            int actual, expected;
            actual = calc.Discount(500, -3);
            expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSale_BigNegativeValue()
        {
            int actual, expected;
            actual = calc.Discount(5050, -3);
            expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSale_BigCountOrder()
        {
            int actual, expected;
            actual = calc.Discount(6400, 15);
            expected = 27;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSale_SmallCountValue()
        {
            int actual, expected;
            actual = calc.Discount(3, 100);
            expected = 15;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSale_BigUsualCount()
        {
            int actual, expected;
            actual = calc.Discount(3, 5050);
            expected = 15;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSale_SmallNegativeCount()
        {
            int actual, expected;
            actual = calc.Discount(-3, 500);
            expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSale_BigNegativeCount()
        {
            int actual, expected;
            actual = calc.Discount(-3, 5050);
            expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSale_BigValue()
        {
            int actual, expected;
            actual = calc.Discount(15, 6400);
            expected = 15;
            Assert.AreEqual(expected, actual);
        }
    }
}
