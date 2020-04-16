using CalculatorSample.Logic;
using Moq;
using NUnit.Framework;
using System.Diagnostics;

namespace CalculatorSample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void TestAddPositive()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            var actual = calc.Add(5, 3);
            mock.Verify(l => l.Log(It.IsAny<string>()),Times.Exactly(1));
            Assert.AreEqual(expected:8,actual:actual);
        }
        [Test]
        public void TestAddNegative()
        {
            var calc = new Calculator(new Logger());
            var actual = calc.Add(-5, -4);
            Assert.AreEqual(expected: -9, actual: actual);
        }
    }
}
