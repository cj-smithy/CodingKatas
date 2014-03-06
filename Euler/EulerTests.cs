
using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices.WindowsRuntime;
using NUnit.Framework;

namespace Euler
{
    [TestFixture]
    public class EulerTests
    {
        [TestCase]
        public void TestSumMultiplesOfThreeAndFiveBelowZero()
        {
            Assert.AreEqual(Euler.SumMultiplesOfThreeAndFive(0), 0);
        }

        [TestCase]
        public void TestSumMultiplesOfThreeAndFiveBelowTen()
        {
            Assert.AreEqual(Euler.SumMultiplesOfThreeAndFive(10), 23);
        }

        [TestCase]
        public void TestFirst2Fibonacci()
        {
            CollectionAssert.AreEqual(Euler.GetFibonacciSequence(2), new[] { 1, 2 });
        }

        [TestCase]
        public void TestFirst10Fibonacci()
        {
            CollectionAssert.AreEqual(Euler.GetFibonacciSequence(10), new []{1,2,3,5,8,13,21,34,55,89});
        }

        [TestCase]
        public void TestSumFirst2Fibonacci()
        {
            Assert.AreEqual(Euler.SumFibonacciSequence(2), 3);    
        }

        [TestCase]
        public void TestSumFirst10Fibonacci()
        {
            Assert.AreEqual(Euler.SumFibonacciSequence(10), 231);
        }

        [TestCase]
        public void TestFibonacciSequenceThatDoesNotExceed100()
        {
            CollectionAssert.AreEqual(Euler.GetFibonacciSequenceUpToMaximum(100), new[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 });
        }

        [TestCase]
        public void TestFibonacciEvenSequenceThatDoesNotExceed100()
        {
            CollectionAssert.AreEqual(Euler.GetFibonacciSequenceUpToMaximum(100, true), new[] { 2, 8, 34 });
        }

        [TestCase]
        public void TestSumFibonacciEvenSequenceThatDoesNotExceed100()
        {
            Assert.AreEqual(Euler.SumFibonacciSequenceUpToMaximum(100, true), 44);
        }

        [TestCase]
        public void TestTwoIsPrimeNumber()
        {
            Assert.IsTrue(Euler.IsPrimeNumber(2));
        }

        [TestCase]
        public void TestFourIsNotPrimeNumber()
        {
            Assert.IsFalse(Euler.IsPrimeNumber(4));
        }

        [TestCase]
        public void TestThreeIsPrimeNumber()
        {
            Assert.IsTrue(Euler.IsPrimeNumber(3));
        }

        [TestCase]
        public void TestTwentyThreeIsPrimeNumber()
        {
            Assert.IsTrue(Euler.IsPrimeNumber(23));
        }

        [TestCase]
        public void Test691IsPrimeNumber()
        {
            Assert.IsTrue(Euler.IsPrimeNumber(691));
        }

        [TestCase]
        public void Test693IsNotPrimeNumber()
        {
            Assert.IsFalse(Euler.IsPrimeNumber(693));
        }

        [TestCase]
        public void TestGetPrimeNumbersUnder2()
        {
            Assert.AreEqual(Euler.GetPrimeNumbers(2).Length, 0);
        }

        [TestCase]
        public void TestGetPrimeNumbersUnder22()
        {
            CollectionAssert.AreEqual(Euler.GetPrimeNumbers(22), new []{2, 3, 5, 7, 11, 13, 17, 19});
        }

        [TestCase]
        public void TestGetPrimeFactorsOf13195()
        {
            CollectionAssert.AreEqual(Euler.GetPrimeFactors(13195), new[] {5, 7, 13, 29});
        }

        [TestCase]
        public void TestGetLargestPrimeFactorOf13195()
        {
            Assert.AreEqual(Euler.GetLargestPrimeFactor(13195), 29 );
        }

        [TestCase]
        public void TestIs99Palindrome()
        {
            Assert.IsTrue(Euler.IsPalindrome(99));
        }

        [TestCase]
        public void TestIs10001Palindrome()
        {
            Assert.IsTrue(Euler.IsPalindrome(10001));
        }

        [TestCase]
        public void TestIs1231Palindrome()
        {
            Assert.IsFalse(Euler.IsPalindrome(1231));
        }

        [TestCase]
        public void TestFindLargestPalindromeThatIsMultipleOfTwoTwoDigitNumbers()
        {
            Assert.AreEqual(Euler.FindLargestPalindrome(2),9009);
        }
    }
}
