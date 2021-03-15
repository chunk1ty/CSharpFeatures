namespace CSharpFeatures.CSharp3.NullableReferenceTypes.After
{
    public class CustomerWithNonNullableProperties
    {
        public CustomerWithNonNullableProperties(string name, AddressWithNonNullableProperties address)
        {
            Name = name;
            Address = address;
        }

        // non-nullable
        public string Name { get; }

        // non-nullable
        public AddressWithNonNullableProperties Address { get; }
    }

    public class AddressWithNonNullableProperties
    {
        public AddressWithNonNullableProperties(string country)
        {
            Country = country;
        }

        // non-nullable
        public string Country { get; }
    }
}
