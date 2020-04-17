using System;
using System.Collections.Specialized;

namespace CSharpFeatures.CSharp2.Generics._1.BeforeGenerics
{
    // Cons
    // - cannot change collection type (what if i what to use integer values?)
    public class ColorsWithStringCollection
    {
        public StringCollection Get()
        {
            Console.WriteLine("ColorsWithStringCollection");
            StringCollection colors = new StringCollection();
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            
            return colors;
        }
    }
}
