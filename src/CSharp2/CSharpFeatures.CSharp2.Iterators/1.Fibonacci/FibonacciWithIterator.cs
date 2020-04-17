using System.Collections.Generic;

namespace CSharpFeatures.CSharp2.Iterators._1.Fibonacci
{
    public class FibonacciWithIterator 
    {
        public static IEnumerable<int> GetNumbers()
        {
            int currentNumber = 0;
            int nextNumber = 1;
            while (true)
            {
                yield return currentNumber;
                int oldCurrent = currentNumber;
                currentNumber = nextNumber;
                nextNumber = nextNumber + oldCurrent;
            }
        }
    }
}
