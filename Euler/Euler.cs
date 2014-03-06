using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

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

        internal static bool IsPrimeNumber(long number)
        {
           // int limit = (int)Math.Ceiling((double)number/2);
            for (long i = 2; i <= (int)Math.Ceiling((double)number / i); i++)
            {
                if (number%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        internal static long[] GetPrimeNumbers(long maximum)
        {
            var primes = new List<long>();
            for (int i = 2; i < maximum; i++)
            {
                if (IsPrimeNumber(i))
                {
                    primes.Add(i);
                }
            }
            return primes.ToArray();
        }

        internal static long[] GetPrimeFactors(long number)
        {
            long[] primes = GetPrimeNumbers(number);
            return primes.Where(t => number%t == 0).ToArray();
        }

        //internal static long[] GetPrimeFactors2(long number)
        //{
            
        //}


        
        internal static long GetLargestPrimeFactor(long number)
        {
            var primes = GetPrimeFactors(number);
            return primes[primes.Length - 1];
        }
    }
}
