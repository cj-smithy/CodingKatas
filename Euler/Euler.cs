﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Euler
    {
        internal static int SumMultiplesOfThreeAndFive(int smallerThan)
        {
            int sum = 0;
            for (int i = 0; i < smallerThan; i++)
            {
                sum += (i%3 == 0 || i%5 == 0) ? i : 0;
            }
            return sum;
        }


        internal static int[] GetFibonacciSequence(int sequenceLength)
        {
            int[] sequence = new int[sequenceLength];
            for (int i = 0; i < sequenceLength; i++)
            {
                if (i < 2)
                {
                    sequence[i] = i+1;
                }
                else
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2];
                }
            }
            return sequence;
        }

        internal static int SumFibonacciSequence(int sequenceLength)
        {
            return GetFibonacciSequence(sequenceLength).Sum();
        }

        internal static int[] GetFibonacciSequenceUpToMaximum(int maximum, bool evenOnly = false)
        {
            var sequence = new List<int>() {1};
            int fibNumber = 2;
            while (fibNumber < maximum)
            {
                sequence.Add(fibNumber);
                int currentIndex = sequence.Count;
                fibNumber = sequence[currentIndex - 1] + sequence[currentIndex - 2];
            }

            if (evenOnly)
            {
                return sequence.Where(x => x%2 == 0).ToArray();
            }
            return sequence.ToArray();
        }

        internal static int SumFibonacciSequenceUpToMaximum(int maximum, bool evenOnly = false)
        {
            return GetFibonacciSequenceUpToMaximum(maximum, evenOnly).Sum();
        }
    }
}