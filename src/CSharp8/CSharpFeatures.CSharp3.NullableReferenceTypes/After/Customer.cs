using System;

namespace CSharpFeatures.CSharp3.NullableReferenceTypes.After
{
    // If I enable Nullable Reference types feature, Compiler warns me that Customer and Address classes are allowing non-nullable properties to be uninitialized.
    //Warning CS8618  Non-nullable property 'Name' must contain a non-null value when exiting constructor.Consider declaring the property as nullable.
    //Warning CS8618 Non-nullable property 'Address' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    //Warning CS8618 Non-nullable property 'Country' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

    // That can be fixed by adding constructors with non-nullable parameters. (Check CustomerWithNonNullableProperties.cs)
    public class Customer
    {
        // nullable
        public string Name { get; set; }

        // nullable
        public Address Address { get; set; }
    }

    public class Address
    {
        // nullable
        public string Country { get; set; }
    }
}
