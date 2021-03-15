using System;

namespace CSharpFeatures.CSharp3.NullableReferenceTypes.Before
{
    public class NullableReferenceTypesPlayGrounder
    {
        public static void Play()
        {
            Customer customer = new Customer();

            // Throws NullReferenceException.
            Console.WriteLine(customer.Address.Country);
        }
    }
}