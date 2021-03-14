using System;

namespace LambdaExpression
{
    public class EvolutionOfDelegateCreation
    {
        delegate void TestDelegate(string s);
        
        public void M(string s)
        {
            Console.WriteLine(s);
        }

        public void Evolution()
        {
            // Original delegate syntax required
            // initialization with a named method.
            TestDelegate originalDelegateCreationSyntax = new TestDelegate(M);
            // Invoke the delegates.
            originalDelegateCreationSyntax("Original delegate creation syntax - C# 1.0");

            // C# 2.0: A delegate can be initialized with
            // inline code, called an "anonymous method." This
            // method takes a string as an input parameter.
            TestDelegate anonymousMethodDelegateCreationSyntax = delegate(string s) { Console.WriteLine(s); };
            // Invoke the delegates.
            anonymousMethodDelegateCreationSyntax("Anonymous method delegate creation syntax - C# 2.0");

            // C# 3.0. A delegate can be initialized with
            // a lambda expression. The lambda also takes a string
            // as an input parameter (x). The type of x is inferred by the compiler.
            TestDelegate lambdaExpressionDelegateCreationSyntax = (x) => { Console.WriteLine(x); };
            // Invoke the delegates.
            lambdaExpressionDelegateCreationSyntax("Lambda expression delegate creation syntax - C# 3.0");
        }
    }
}