using System;
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

            Console.Read();


        }
    }
}
