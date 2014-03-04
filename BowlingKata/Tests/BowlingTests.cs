using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    internal class BowlingTests
    {
        [SetUp]
        public void SetUp()
        {
            _game = BuildGame();
        }

        private Game _game = new Game();

        [TestCase]
        public void TestGutterGameScoresZero()
        {
            RollMany(_game, 20, 0);
            Assert.AreEqual(0, _game.GetScore());
        }

        [TestCase]
        public void TestAllOnesGame()
        {
            RollMany(_game, 20, 1);
            Assert.AreEqual(20, _game.GetScore());
        }

        [TestCase]
        public void TestOneSpare()
        {
            RollSpare();
            _game.Roll(3);
            RollMany(_game, 17, 0);
            Assert.AreEqual(16, _game.GetScore());
        }

        [TestCase]
        public void TestOneStrike()
        {
            _game.Roll(10);
            _game.Roll(3);
            _game.Roll(4);
            RollMany(_game, 16, 0);
            Assert.AreEqual(24, _game.GetScore());
        }

        [TestCase]
        public void TestPerfectGame()
        {
            RollMany(_game, 12, 10);
            Assert.AreEqual(300, _game.GetScore());
        }

        [TestCase, ExpectedException(typeof(System.ApplicationException))]
        public void TestTooManyRolls()
        {
            RollMany(_game, 24, 0);
        }

        private void RollSpare()
        {
            _game.Roll(5);
            _game.Roll(5); // spare!
        }


        private static void RollMany(Game game, int rolls, int pinsKnockedDown)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pinsKnockedDown);
            }
        }

        private static Game BuildGame()
        {
            return new Game();
        }
    }
}