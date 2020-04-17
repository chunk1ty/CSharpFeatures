using System;
using System.Collections.Generic;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using CSharpFeatures.CSharp2.Iterators._1.Fibonacci;
using CSharpFeatures.CSharp2.Iterators._2.EvaluationFinallyBlock;

namespace CSharpFeatures.CSharp2.Iterators
{
    public class Program
    {
        private const int Range = 1000;

        public static void Main(string[] args)
        {
            // FibonacciPerformanceComparison();

            IteratorBlockWithFinallyStatement();
        }

        private static void FibonacciPerformanceComparison()
        {
            var benchmark = BenchmarkRunner.Run<Program>();
            Console.WriteLine(benchmark);
            //| Method            | Mean        | Error     | StdDev    |
            //| ------------------| ------------| ----------| ----------|
            //| FibonacciIterator | 378.5 ns    | 3.18 ns   | 2.98 ns   |
            //| FibonacciList     | 23,066.7 ns | 170.92 ns | 159.88 ns |

            var stopWatch = Stopwatch.StartNew();
            FibonacciIterator();
            Console.WriteLine($"FibonacciIterator {stopWatch.Elapsed}");

            stopWatch = Stopwatch.StartNew();
            FibonacciList();
            Console.WriteLine($"FibonacciList {stopWatch.Elapsed}");
        }

        [Benchmark]
        public static void FibonacciIterator()
        {
            decimal total = 0;
            foreach (var value in FibonacciWithIterator.GetNumbers())
            {
                total += value;
                if (value > Range)
                {
                    break;
                }
            }
        }

        [Benchmark]
        public static void FibonacciList()
        {
            decimal total = 0;
            foreach (var number in FibonacciWithList.GetNumbers(Range))
            {
                total += number;
            }
        }

        private static void IteratorBlockWithFinallyStatement()
        {
            // when Iterator is not interrupt finally block by itself
            foreach (string value in IteratorBlockWithFinally.Iterator())
            {
                Console.WriteLine("Received value: {0}", value);
            }

            // hidden using statement calls Dispose on IEnumerable<string>
            foreach (string value in IteratorBlockWithFinally.Iterator())
            {
                Console.WriteLine("Received value: {0}", value);
                if (value != null)
                {
                    break;
                }
            }

            // foreach statement is translated to while loop
            IEnumerable<string> enumerable = IteratorBlockWithFinally.Iterator();
            using (IEnumerator<string> enumerator = enumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    string value = enumerator.Current;
                    Console.WriteLine("Received value: {0}", value);
                    if (value != null)
                    {
                        break;
                    }
                }
            }
        }
    }
}
