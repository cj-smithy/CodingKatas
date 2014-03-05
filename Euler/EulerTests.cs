
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
    }
}
