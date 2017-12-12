using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        private StringCalculator sc = new StringCalculator();
        [TestMethod]
        public void EmptyString()
        {
            int expected = 0;
            int actual = sc.Add("");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZeroReturnsZero()
        {
            int expected = 0;
            int actual = sc.Add("0");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OneReturnsOne()
        {
            int expected = 1;
            int actual = sc.Add("1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TwoReturnsTwo()
        {
            int expected = 2;
            int actual = sc.Add("2");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SingleRandomDigit()
        {
            Random random = new Random();
            int expected = random.Next(0,1000);
            int actual = sc.Add(expected.ToString());
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TwoAndTwo()
        {
            int expected = 3;
            int actual = sc.Add("1,2");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TwentyeightAndTwelve()
        {
            int expected = 40;
            int actual = sc.Add("28,12");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OneTwoThree()
        {
            int expected = 6;
            int actual = sc.Add("1,2,3");
            Assert.AreEqual(expected, actual);
        }
    }
}
