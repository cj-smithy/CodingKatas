using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingKata
{
    public class BowlingGame
    {
        int[] _rolls = new int[20];
        int _currentRoll = 0;

        public void Roll(int pinsKnockedDown)
        {
            _rolls[_currentRoll] = pinsKnockedDown;
            _currentRoll++;
        }

        public int GetScore()
        {
            int score = 0;
            for (int i = 0; i < _rolls.Length; i++)
            {
                score += _rolls[i];
            }
            return score;
        }
    }
}
