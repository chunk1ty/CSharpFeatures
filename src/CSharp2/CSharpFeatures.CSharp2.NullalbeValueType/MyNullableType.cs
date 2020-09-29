using System;

namespace CSharpFeatures.CSharp2.NullalbeValueType
{
    // primitive version of Nullable<> would look like this
    // solve the problem when value type can be null
    public struct MyNullableType<T> where T : struct
    {
        private readonly T _value;
        private readonly bool _hasValue;

        public MyNullableType(T value)
        {
            _value = value;
            _hasValue = true;
        }

        public bool HasValue => _hasValue;

        public T Value
        {
            get
            {
                if (!_hasValue)
                {
                    throw new InvalidOperationException();
                }

                return _value;
            }
        }
    }
}