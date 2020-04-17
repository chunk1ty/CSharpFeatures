using System.Collections.Generic;

namespace CSharpFeatures.CSharp2.Generics._2.AfterGenerics
{
    // Generics save the day
    public class ColorsWithGenerics
    {
        public List<string> Get()
        {
            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");

            return colors;
        }
    }
}
