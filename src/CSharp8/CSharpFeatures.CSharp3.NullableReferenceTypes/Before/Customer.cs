namespace CSharpFeatures.CSharp3.NullableReferenceTypes.Before
{
    // Traditional null reference issue.
    public class Customer
    {
        // nullable
        public string Name { get; }

        // nullable
        public Address Address { get; }
    }

    public class Address
    {
        // nullable
        public string Country { get; }
    }
}
