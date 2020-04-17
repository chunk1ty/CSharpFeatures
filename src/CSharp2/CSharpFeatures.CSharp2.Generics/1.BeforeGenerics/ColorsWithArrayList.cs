using System;
using System.Collections;

namespace CSharpFeatures.CSharp2.Generics._1.BeforeGenerics
{
    // Cons
    // - i can add everything in colors collection
    public class ColorsWithArrayList
    {
        public ArrayList Get()
        {
            Console.WriteLine("ColorsWithArrayList");
            ArrayList colors = new ArrayList();
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            // compiler doesn't not do type checking 
            //colors.Add(17); 
            return colors;
        }
    }
}
