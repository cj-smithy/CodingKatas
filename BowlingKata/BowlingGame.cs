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
            _rolls[_currentRoll++] = pinsKnockedDown;
        }

        public int GetScore()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                int frameScore = _rolls[frameIndex];
                if (IsStrike(frameScore))
                {
                    score += frameScore + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
                    frameIndex ++;
                }
                else
                {
                    frameScore += _rolls[frameIndex + 1];
                    if (IsSpare(frameScore) && frameIndex < 20)
                    {
                        frameScore += _rolls[frameIndex+2];
                    }
                    score += frameScore;
                    frameIndex += 2;
                }
            }
            return score;
        }

        private static bool IsStrike(int frameScore)
        {
            return frameScore >= 10;
        }

        private bool IsSpare(int frameScore)
        {
            return frameScore >= 10;
        }
    }
}
