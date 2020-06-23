namespace Geometry
{
    using System;

    /// <summary>
    /// Round class
    /// </summary>
    public class Round : Circle
    {
        /// <summary>
        /// Initializes a new instance of the Round class
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="radius">Radius of round</param>
        public Round(double x, double y, double radius) : base(x, y, radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Calculating area of the round
        /// </summary>
        /// <returns>Area of the round</returns>
        public override double Area
        {
            get
            {
                return Math.PI * Math.Pow(this.Radius, 2);
            }
        }

        /// <summary>
        /// Calculating length of round
        /// </summary>
        /// <returns>Length of round</returns>
        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * this.Radius;
            }
        }
    }
}
