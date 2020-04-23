using CalculatorSample.Logic;
using Moq;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace CalculatorSample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator Init()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            return calc;
        }

        [Test]
        public void TestAddPositive()
        {
            var calc = Init();
            var actual = calc.Add(5, 3);
            Assert.AreEqual(expected: 8, actual: actual);
        }
        [Test]
        public void TestAddNegative()
        {
            var calc = Init();
            var actual = calc.Add(-5, -3);
            Assert.AreEqual(expected: -8, actual: actual);
        }

        [Test]
        public void TestMinusPositive()
        {
            var calc = Init();
            var actual = calc.Minus(5, 3);
            Assert.AreEqual(expected: 2, actual: actual);
        }
        [Test]
        public void TestMinusNegative()
        {
            var calc = Init();
            var actual = calc.Minus(-5, -3);
            Assert.AreEqual(expected: -2, actual: actual);
        }

        [Test]
        public void TestMultiplyPositive()
        {
            var calc = Init();
            var actual = calc.Multiply(5, 3);
            Assert.AreEqual(expected: 15, actual: actual);
        }
        [Test]
        public void TestMultiplyNegative()
        {
            var calc = Init();
            var actual = calc.Multiply(-5, -3);
            Assert.AreEqual(expected: 15, actual: actual);
        }

        [Test]
        public void TestDividePositive()
        {
            var calc = Init();
            var actual = calc.Divide(6, 3);
            Assert.AreEqual(expected: 2, actual: actual);
        }
        [Test]
        public void TestDivideNegative()
        {
            var calc = Init();
            var actual = calc.Divide(-6, -3);
            Assert.AreEqual(expected: 2, actual: actual);
        }

        //SearchNumbers

        [Test]
        public void TestSearchNumbersPositive()
        {
            var calc = Init();
            var actual = calc.SearchNumbers(4, 2);
            Assert.AreEqual(expected: new int[] { 4, 13, 40 }, actual: actual);
        }

        [Test]
        public void TestSearchNumbersPositive2()
        {
            var calc = Init();
            var actual = calc.SearchNumbers(12, 3);
            Assert.AreEqual(expected: new int[] { 66, 129, 930 }, actual: actual);
        }

        [Test]
        public void TestSearchNumbersPositive3()
        {
            var calc = Init();
            var actual = calc.SearchNumbers(6, 1);
            Assert.AreEqual(expected: new int[] { 1, 6, 6 }, actual: actual);
        }

        [Test]
        public void TestSearchNumbersPositive4()
        {
            var calc = Init();
            var actual = calc.SearchNumbers(12, 1);
            Assert.AreEqual(expected: new int[]{}, actual: actual);
        }

        [Test]
        public void TestSearchNumbersNegativeNumber()
        {
            var calc = Init();
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => calc.SearchNumbers(-4, 2));
            Assert.IsTrue(ex.Message.Contains("Param < 0"));
        }

        [Test]
        public void TestSearchNumbersNegativeNumber2()
        {
            var calc = Init();
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => calc.SearchNumbers(4, -2));
            Assert.IsTrue(ex.Message.Contains("Param < 0"));
        }
    }
}
