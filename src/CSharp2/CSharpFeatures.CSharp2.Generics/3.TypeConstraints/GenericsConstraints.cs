using System;

namespace CSharpFeatures.CSharp2.Generics._3.TypeConstraints
{
    public interface ISomething
    {
        void Logic();
    }

    public class Something : ISomething
    {
        public void Logic()
        {
            Console.WriteLine("important logic");
        }
    }

    public class GenericsConstraints
    {
        public void GenericMethod<T>()  where T : ISomething, new()
        {
            T myType = new T();
            myType.Logic();
        }
    }
}
