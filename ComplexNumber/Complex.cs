namespace ComplexNumber
{
    using System;

    /// <summary>
    /// Complex number class
    /// </summary>
    public class Complex : IComparable
    {
        /// <summary>
        /// Initializes a new instance of the Complex class
        /// </summary>
        public Complex(double Re, double Im)
        {
            this.Re = Re;
            this.Im = Im;
        }

        /// <summary>
        /// Gets or sets real part
        /// </summary>
        public double Re { get; private set; }

        /// <summary>
        /// Gets or sets imagine part
        /// </summary>
        public double Im { get; private set; }

        /// <summary>
        /// Gets modulus of number
        /// </summary>
        private double Modulus
        {
            get
            {
                return Math.Sqrt((this.Re * this.Re) + (this.Im * this.Im));
            }
        }

        /// <summary>
        /// Compare method for complex numbers
        /// </summary>
        /// <param name="other">Other complex number</param>
        /// <returns>Positive if this object more than other, Negative if less, 0 if they are equal</returns>
        public int CompareTo(Complex other)
        {
            return Math.Sign(this.Modulus - other.Modulus);
        }

        /// <summary>
        /// Interface realization of method
        /// </summary>
        /// <param name="obj">Other object</param>
        /// <returns>Positive if this object more than other, Negative if less, 0 if they are equal</returns>
        public int CompareTo(object obj)
        {
            if (obj is Complex value)
            {
                return this.CompareTo(value);

            }
            throw new ArgumentException("Not complex number");
        }
    }
}
