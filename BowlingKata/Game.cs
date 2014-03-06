using System;
using System.Collections.Generic;
using NUnit.Framework.Constraints;

namespace BowlingKata
{
    public class Game
    {
        private readonly List<Frame> _frames = new List<Frame>();
        private int _currentFrame;

        public Game()
        {
            SetupEmptyGame();
        }

        private void SetupEmptyGame()
        {
            for (int i = 0; i < 10; i++)
            {
                _frames.Add(new Frame());
            }
        }

        public void Roll(int pinsKnockedDown)
        {
            if (_frames[_currentFrame].HasEnded)
            {
                _currentFrame++;
            }

            if (_currentFrame >= _frames.Count)
            {
                throw new ApplicationException("Maximum number of frames exceeded.");
            }

            _frames[_currentFrame].Roll(pinsKnockedDown);
<<<<<<< HEAD

            if (_currentFrame >= 10)
            {
                if (_frames[_currentFrame].IsStrike())
                {
                    // is this the 10th frame
                    if (_currentFrame == 10)
                    {
                        _frames.Add(new Frame());
                    }
                    else if (_currentFrame == 11)
                    {
                        _frames.Add(new Frame(1));
                    }
                }
                else if (_frames[_currentFrame].IsSpare() && _currentFrame == 11)
                {
                    _frames.Add(new Frame(1));
                }
            }
=======
>>>>>>> 9c8155f3194a90a5bd836edc44d7f23c072a9867
        }

        public int GetScore()
        {
            int score = 0;
            for (int frameIndex = 0; frameIndex < _frames.Count; frameIndex++)
            {
                var frame = _frames[frameIndex];
                if (frame.IsStrike())
                {
                    score += 10 + StrikeBonus(frameIndex);
                }
                else if (frame.IsSpare())
                {
<<<<<<< HEAD
                    score += 10 + (frameIndex < _frames.Count ? SpareBonus(frameIndex) : 0);
=======
                    score += 10 + SpareBonus(frameIndex);
>>>>>>> 9c8155f3194a90a5bd836edc44d7f23c072a9867
                }
                else
                {
                    score += frame.GetScore();
                }
            }
            return score;
        }

        private int StrikeBonus(int frameIndex)
        {
            return _frames[frameIndex+1].GetScore();
        }

        private int SpareBonus(int frameIndex)
        {
            return _frames[frameIndex + 1].GetScore();
        }
    }
}