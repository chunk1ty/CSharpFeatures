using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace CSharpFeatures.CSharp2.Iterators._1.Fibonacci
{
    public class FibonacciWithList
    {
        [Benchmark]
        public static IEnumerable<int> GetNumbers(int range)
        {
            List<int> numbers = new List<int>();
            int currentNumber = 0;
            int nextNumber = 1;

            for (int i = 0; i < range; i++)
            {
                numbers.Add(currentNumber);
                
                int oldCurrent = currentNumber;
                currentNumber = nextNumber;
                nextNumber = nextNumber + oldCurrent;
            }

            return numbers;
        }
    }
}
