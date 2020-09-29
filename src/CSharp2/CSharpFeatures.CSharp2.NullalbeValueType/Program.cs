using System;

namespace CSharpFeatures.CSharp2.NullalbeValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNullableType<int> myInt = new MyNullableType<int>(17);
            Console.WriteLine(myInt.Value);
        }
    }
}