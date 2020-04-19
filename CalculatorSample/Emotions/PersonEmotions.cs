using System;
using NUnit.Framework;

namespace Emotions
{
    //no SOLID
    public class PersonEmotions
    {

        internal string EmotionCheerful(string emotion)
        {
            if (string.IsNullOrEmpty(emotion))
            {
                return (";-)");
            }
            else
            {
                return emotion;
            }
        }

        internal string EmotionGlad(string emotion)
        {
            if (string.IsNullOrEmpty(emotion))
            {
                return (":-)");
            }
            else
            {
                return emotion;
            }
        }

        internal string EmotionHappy(string emotion)
        {
            if (string.IsNullOrEmpty(emotion))
            {
                return (":-))");
            }
            else
            {
                return emotion;
            }
        }

        internal string EmotionSad(string emotion)
        {
            if (string.IsNullOrEmpty(emotion))
            {
                return (":-(");
            }
            else
            {
                return emotion;
            }
        }

    }

    [TestFixture]
    public class PersonEmotionsTests
    {
        //PersonEmotionsTests
        [Test]
        public void TestPersonEmotionsPositive()
        {
            var actual = new PersonEmotions().EmotionSad(String.Empty);
            Assert.AreEqual(expected: ":-(", actual: actual);
        }
        [Test]
        public void TesPersonEmotionsNegative()
        {
            var actual = new PersonEmotions().EmotionHappy("");
            Assert.AreNotEqual(expected: ":-(", actual: actual);
        }
    }
}
