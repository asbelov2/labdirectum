namespace StringEqual
{
    using System;

    /// <summary>
    /// StringValue class
    /// </summary>
    public class StringValue
    {
        /// <summary>
        /// Initializes a new instance of the StringValue class
        /// </summary>
        /// <param name="value">Value string</param>
        public StringValue(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets or sets Value
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// Redefines equality operator
        /// </summary>
        /// <param name="left">Left parameter</param>
        /// <param name="right">Right parameter</param>
        /// <returns>Equal or not</returns>
        public static bool operator ==(StringValue left, StringValue right)
        {
            return StringValue.Equals(left, right);
        }

        /// <summary>
        /// Redefines unequality operator
        /// </summary>
        /// <param name="left">Left parameter</param>
        /// <param name="right">Right parameter</param>
        /// <returns>Not equal if true</returns>
        public static bool operator !=(StringValue left, StringValue right)
        {
            return !StringValue.Equals(left, right);
        }

        /// <summary>
        /// Redefines equality method
        /// </summary>
        /// <param name="str">String to compare</param>
        /// <returns>Equal or not</returns>
        public override bool Equals(object str)
        {
            return str.GetHashCode() == this.GetHashCode();
        }

        /// <summary>
        /// Redefines hash code method
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Value);
        }
    }
}