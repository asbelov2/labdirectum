namespace Geometry
{
    using System;

    /// <summary>
    /// Circle class
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the Circle class
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="radius">Outer radius</param>
        public Circle(double x, double y, double radius) : base(x, y)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets radius
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Circle hasn't area
        /// </summary>
        /// <returns>Area of the circle</returns>
        public override double Area
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Calculating length of circle
        /// </summary>
        /// <returns>Length of cirlce</returns>
        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * this.Radius;
            }
        }
    }
}
