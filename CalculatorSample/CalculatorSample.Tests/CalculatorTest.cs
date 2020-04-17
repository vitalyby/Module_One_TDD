using CalculatorSample.Logic;
using Moq;
using NUnit.Framework;
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
    }
}
