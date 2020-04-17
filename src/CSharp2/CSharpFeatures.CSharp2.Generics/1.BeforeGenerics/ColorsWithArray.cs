using System;

namespace CSharpFeatures.CSharp2.Generics._1.BeforeGenerics
{
    // Cons
    // -fixed sized (3)
    public class ColorsWithArray
    {
        public string[] Get()
        {
            Console.WriteLine("ColorsWithArray");
            string[] colors = new string[3];
            colors[0] = "red";
            colors[1] = "blue";
            colors[2] = "green";

            return colors;
        }
    }
}
