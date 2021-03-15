using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.CSharp3.NullableReferenceTypes.After
{
    public class NullableReferenceTypesPlayGrounder
    {
        public static void Play()
        {
            //Customer customer = new Customer();
            //Console.WriteLine(customer.Address.Country);

            //AddressWithNonNullableProperties address = new AddressWithNonNullableProperties("Bulgaria");
            //CustomerWithNonNullableProperties customer = new CustomerWithNonNullableProperties("Andriyan", address);
            //Console.WriteLine(customer.Address.Country);

            CustomerWithNullableProperties customer = new CustomerWithNullableProperties("Andriyan");
            Console.WriteLine(customer.Address.Country);
        }
    }
}
