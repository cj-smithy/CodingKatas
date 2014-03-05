using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    class FrameTests
    {
        [TestCase]
        public void TestFrameWithTooManyRolls()
        {
            var frame = new Frame(2);
            frame.Roll(1);
            frame.Roll(2);
            frame.Roll(10);
            Assert.AreEqual(frame.GetScore(), 3);
        }

        [TestCase]
        public void TestFrameRollWithTooManyPins()
        {
            var frame = new Frame(2);
            frame.Roll(6);
            frame.Roll(5);
            Assert.AreEqual(frame.GetScore(), 10);
        }

        [TestCase]
        public void TestFrameWithStrike()
        {
            var frame = new Frame(2);
            frame.Roll(10);
            Assert.IsTrue(frame.IsStrike());
            Assert.IsFalse(frame.IsSpare());
            Assert.IsTrue(frame.HasEnded);
        }

        [TestCase]
        public void TestFrameWithSpare()
        {
            var frame = new Frame(2);
            frame.Roll(9);
            frame.Roll(1);
            Assert.IsTrue(frame.IsSpare());
            Assert.IsFalse(frame.IsStrike());
        }

        [TestCase]
        public void TestFrameHasEnded()
        {
            var frame = new Frame();
            frame.Roll(9);
            frame.Roll(1);
            Assert.IsTrue(frame.HasEnded);
        }
    }
}
