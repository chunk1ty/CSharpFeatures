using System;
using CSharpFeatures.CSharp2.Generics._1.BeforeGenerics;
using CSharpFeatures.CSharp2.Generics._2.AfterGenerics;
using CSharpFeatures.CSharp2.Generics._3.TypeConstraints;
using CSharpFeatures.CSharp2.Generics._4.GenericTypeInitialization;

namespace CSharpFeatures.CSharp2.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //BeforeGenerics();

            //Generics();
           
            //GenericConstraints();

            //GenericTypeInitialization();
        }

        private static void BeforeGenerics()
        {
            ColorsWithArray colorsWithArray = new ColorsWithArray();
            foreach (var color in colorsWithArray.Get())
            {
                Console.WriteLine(color);
            }

            ColorsWithArrayList colorsWithArrayList = new ColorsWithArrayList();
            foreach (var color in colorsWithArrayList.Get())
            {
                Console.WriteLine(color);
            }

            ColorsWithStringCollection colorsWithStringCollection = new ColorsWithStringCollection();
            foreach (var color in colorsWithStringCollection.Get())
            {
                Console.WriteLine(color);
            }
        }

        private static void Generics()
        {
            ColorsWithGenerics colorsWithGenerics = new ColorsWithGenerics();
            foreach (var color in colorsWithGenerics.Get())
            {
                Console.WriteLine(color);
            }
        }

        private static void GenericConstraints()
        {
            GenericsConstraints genericsConstraints = new GenericsConstraints();
            genericsConstraints.GenericMethod<Something>();
        }

        private static void GenericTypeInitialization()
        {
            // static
            //GenericCounter<string>.Increment();
            //GenericCounter<string>.Increment();
            //GenericCounter<string>.Display();
            //GenericCounter<int>.Display();
            //GenericCounter<int>.Increment();
            //GenericCounter<int>.Display();

            // instance
            GenericCounter<string> stringGenericCounter = new GenericCounter<string>();
            stringGenericCounter.IncrementInstance();
            stringGenericCounter.IncrementInstance();
            stringGenericCounter.IncrementInstance();
            stringGenericCounter.DisplayInstance();

            GenericCounter<int> intGenericCounter = new GenericCounter<int>();
            intGenericCounter.IncrementInstance();
            intGenericCounter.DisplayInstance();
        }
    }
}
