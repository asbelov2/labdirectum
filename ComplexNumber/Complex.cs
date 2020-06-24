﻿namespace ComplexNumber
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
        public Complex()
        {
        }

        /// <summary>
        /// Gets or sets real part
        /// </summary>
        public double Re { get; set; }  // Лучше сделать неизменяемым. Убрать сет. Задавать через конструктор.

        /// <summary>
        /// Gets or sets imagine part
        /// </summary>
        public double Im { get; set; }

        /// <summary>
        /// Compare method for complex numbers
        /// </summary>
        /// <param name="other">Other complex number</param>
        /// <returns>Positive if this object more than other, Negative if less, 0 if they are equal</returns>
        public int CompareTo(Complex other)
        {
            return Math.Sign(Math.Sqrt((this.Re * this.Re) + (this.Im * this.Im)) - Math.Sqrt((other.Re * other.Re) + (other.Im * other.Im)));  // Лучше сделать свойство с вычислением абсолютного значения.
        }

        /// <summary>
        /// Interface realization of method
        /// </summary>
        /// <param name="obj">Other object</param>
        /// <returns>Positive if this object more than other, Negative if less, 0 if they are equal</returns>
        public int CompareTo(object obj)
        {
            if (this.GetType() != obj.GetType())  // Более правильная проверка: obj is Complex
            {
                throw new ArgumentException("Not complex number");
            }

            return this.CompareTo((Complex)obj);  // Либо можно даже obj is Complex value. И value передавать в CompareTo в if конструкции.
                                                  // А исключение бросать после if'а.
        }
    }
}
