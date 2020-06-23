using System;

namespace StringEqual
{
    public class StringValue
    {
        public string Value { get; private set; }
        public StringValue(string value)
        {
            this.Value = value;
        }
        public override bool Equals(object str)
        {
            return (str.GetHashCode()==this.GetHashCode());
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}

