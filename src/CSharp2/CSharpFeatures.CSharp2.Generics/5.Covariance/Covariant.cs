namespace CSharpFeatures.CSharp2.Generics._5.Covariance
{
    public class Fruit { }

    public class Apple : Fruit { }

    public interface ICovariant<out T> { }

    public class Covariant<T> : ICovariant<T> { }

    // enable polymorphism in generics 
    public class CovariantUsage
    {
        public void Example()
        {
            // possible because its covariant (out keyword)
            ICovariant<Fruit> fruit = new Covariant<Apple>();
        }
    }
}
