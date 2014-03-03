using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingKata
{
    public class BowlingGame
    {
        int _score = 0;

        public void roll(int pinsKnockedDown)
        {
            _score += pinsKnockedDown;
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
