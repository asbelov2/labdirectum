namespace Geometry
{
    using System;

    /// <summary>
    /// Ring class
    /// </summary>
    public class Ring : Shape
    {
        /// <summary>
        /// Initializes a new instance of the Ring class
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="outerRadius">Outer radius</param>
        /// <param name="innerRadius">Inner radius</param>
        public Ring(double x, double y, double outerRadius, double innerRadius) : base(x, y)
        {
            if (innerRadius < outerRadius)
            {
                this.OuterRadius = outerRadius;
                this.InnerRadius = innerRadius;
            }
            else
            {
                throw new Exception("Wrong ring parameters (inner radius more than outer).");
            }
        }

        /// <summary>
        /// Gets or sets inner radius
        /// </summary>
        public double InnerRadius { get; set; }

        /// <summary>
        /// Gets or sets outer radius
        /// </summary>
        public double OuterRadius { get; set; }

        /// <summary>
        /// Calculating area of the ring
        /// </summary>
        /// <returns>Area of the ring</returns>
        public override double Area
        {
            get
            {
                return Math.PI * (Math.Pow(this.OuterRadius, 2) - Math.Pow(this.InnerRadius, 2));
            }
        }

        /// <summary>
        /// Calculating length of outer circle
        /// </summary>
        /// <returns>Length of outer cirlce</returns>
        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * this.OuterRadius;
            }
        }
    }
}
