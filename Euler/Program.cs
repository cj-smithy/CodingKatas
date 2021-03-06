﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of the multiples of 3 and 5 under 1000 = {0}",
                Euler.SumMultiplesOfThreeAndFive(1000));

            Console.WriteLine("Sum of even Fibonacci numbers up to 4 million = {0}",
                Euler.SumFibonacciSequenceUpToMaximum(4000000, true));

            Console.WriteLine("Largest prime factor of 600851475143 = {0}",
                Euler.GetLargestPrimeFactor(600851475143));

            Console.WriteLine("Largest palindrome made from the product of two 3-digit numbers = {0}",
                Euler.FindLargestPalindrome(3));

            Console.Read();


        }
    }
}
