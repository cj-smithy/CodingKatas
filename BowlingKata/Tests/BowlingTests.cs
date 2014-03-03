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
        [TestCase]
        public void TestGutterGameScoresZero()
        {
            var game = BuildGame();
            RollMany(game, 20, 0); 
            Assert.AreEqual(0, game.GetScore());
        }

        [TestCase]
        public void TestAllOnesGame()
        {
            var game = BuildGame();
            RollMany(game, 20, 1);
            Assert.AreEqual(20, game.GetScore());
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
                game.roll(pinsKnockedDown);
            }
        }
        #endregion Helper stuff
    }
}
