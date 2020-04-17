using System;

namespace CSharpFeatures.CSharp2.Generics._4.GenericTypeInitialization
{
    // Each closed, constructed type is initialized separately and has its own independent set of static fields.
    public class GenericCounter<T>
    {
        private static int value;

        static GenericCounter()
        {
            Console.WriteLine("Initializing counter for {0}", typeof(T));
        }

        public static void Increment()
        {
            value++;
        }

        public static void Display()
        {
            Console.WriteLine("Counter for {0}: {1}", typeof(T), value);
        }

        public void IncrementInstance()
        {
            value++;
        }

        public void DisplayInstance()
        {
            Console.WriteLine("Counter for {0}: {1}", typeof(T), value);
        }
    }
}
