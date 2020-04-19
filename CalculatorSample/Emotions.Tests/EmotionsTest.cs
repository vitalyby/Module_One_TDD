using Emotions.Emotion;
using NUnit.Framework;

namespace Emotions.Tests
{

    [TestFixture]
    public class EmotionsTest
    {
        [Test]
        public void TestSadPositive()
        {
            var actual = new Sad().FaceMask();
            Assert.AreEqual(expected: ":-(", actual: actual);
        }
        [Test]
        public void TestSadNegative()
        {
            var actual = new Sad().FaceMask();
            Assert.AreNotEqual(expected: ":-)", actual: actual);
        }

        [Test]
        public void TestHappyPositive()
        {
            var actual = new Happy().FaceMask();
            Assert.AreEqual(expected: ":-))", actual: actual);
        }
        [Test]
        public void TestHappyNegative()
        {
            var actual = new Happy().FaceMask();
            Assert.AreNotEqual(expected: ":-)", actual: actual);
        }

        [Test]
        public void TestGladPositive()
        {
            var actual = new Glad().FaceMask();
            Assert.AreEqual(expected: ":-)", actual: actual);
        }
        [Test]
        public void TestGladNegative()
        {
            var actual = new Glad().FaceMask();
            Assert.AreNotEqual(expected: ":-(", actual: actual);
        }

        [Test]
        public void TestCheerfulPositive()
        {
            var actual = new Cheerful().FaceMask();
            Assert.AreEqual(expected: ";-)", actual: actual);
        }
        [Test]
        public void TestCheerfulNegative()
        {
            var actual = new Cheerful().FaceMask();
            Assert.AreNotEqual(expected: ":-(", actual: actual);
        }

    }
}
