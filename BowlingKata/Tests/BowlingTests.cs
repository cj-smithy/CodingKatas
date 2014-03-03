using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    class BowlingTests
    {
        BowlingGame _game = new BowlingGame();

        [SetUp]
        public void SetUp()
        {
            _game = BuildGame();
        }
        
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
            _game.Roll(5);
            _game.Roll(5);  // spare!
            _game.Roll(3);
            RollMany(_game, 17, 0);
            Assert.AreEqual(16, _game.GetScore());
        }

        #region Helper stuff
        private static BowlingGame BuildGame()
        {
            return new BowlingGame();
        }

        private static void RollMany(BowlingGame game, int rolls, int pinsKnockedDown)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pinsKnockedDown);
            }
        }
        #endregion Helper stuff
    }
}
