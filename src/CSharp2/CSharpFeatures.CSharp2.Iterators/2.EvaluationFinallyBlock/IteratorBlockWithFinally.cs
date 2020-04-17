using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.CSharp2.Iterators._2.EvaluationFinallyBlock
{
    public class IteratorBlockWithFinally
    {
        public static IEnumerable<string> Iterator()
        {
            try
            {
                Console.WriteLine("Before first yield");
                yield return "first";
                Console.WriteLine("Between yields");
                yield return "second";
                Console.WriteLine("After second yield");
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
        }
    }
}
