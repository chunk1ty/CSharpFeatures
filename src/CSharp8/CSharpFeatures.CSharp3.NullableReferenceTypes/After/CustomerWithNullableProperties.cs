namespace CSharpFeatures.CSharp3.NullableReferenceTypes.After
{
    // Warning CS8602  Dereference of a possibly null reference.

    public class CustomerWithNullableProperties
    {
        public CustomerWithNullableProperties(string name)
        {
            Name = name;
        }

        // non-nullable
        public string Name { get; }

        // nullable
        public AddressWithNullableProperties? Address { get; }
    }

    public class AddressWithNullableProperties
    {
        // nullable
        public string? Country { get; }
    }
}
