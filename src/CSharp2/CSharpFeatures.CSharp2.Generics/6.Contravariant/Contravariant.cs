namespace CSharpFeatures.CSharp2.Generics._6.Contravariant
{
    public class Fruit { }

    public class Apple : Fruit { }

    public interface ICovariant<in T> { }

    public class Covariant<T> : ICovariant<T> { }

    // basically I downcast Fruit to Apple 
    // useful when do some kind of comparison 
    public class ContravariantUsage
    {
        public void Example()
        {
            // possible because its covariant (in keyword)
            ICovariant<Apple> fruit = new Covariant<Fruit>();
        }
    }
}
