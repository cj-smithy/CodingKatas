using System;

namespace BowlingKata
{
    internal class Frame
    {
        readonly int[] _rolls;
        int _currentBall;

        public Frame()
        {
            _rolls = new int[2];
        }

        public Frame(int numberOfRolls)
        {
            _rolls = new int[numberOfRolls];
        }

        public void Roll(int numberOfPinsKnockedDown)
        {
            if (_currentBall < _rolls.Length)
            {
                _rolls[_currentBall] = numberOfPinsKnockedDown;
                _currentBall++;
            }
        }

        public int GetScore()
        {
            int score = 0;
            for (int i = 0; i < _currentBall; i++)
            {
                score += _rolls[i];
            }
            return Math.Min(score, 10);
        }

        internal bool IsStrike()
        {
            return (_currentBall > 0) && _rolls[0] == 10;
        }

        internal bool IsSpare()
        {
            return (_currentBall > 1) && (_rolls[0] + _rolls[1] >= 10);
        }

        public bool HasEnded
        {
            get { return (_currentBall > 1 || IsStrike()); }
        }
    }
}
