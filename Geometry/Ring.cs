namespace Geometry
{
    using System;

    /// <summary>
    /// Ring class
    /// </summary>
    public class Ring : Round
    {
        /// <summary>
        /// Field for inner radius
        /// </summary>
        private double innerRadius;

        /// <summary>
        /// Initializes a new instance of the Ring class
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="outerRadius">Outer radius</param>
        /// <param name="innerRadius">Inner radius</param>
        public Ring(double x, double y, double outerRadius, double innerRadius) : base(x, y, outerRadius)
        {
            this.InnerRadius = innerRadius;
        }

        /// <summary>
        /// Gets or sets inner radius
        /// </summary>
        public double InnerRadius 
        { 
            get
            {
                return this.innerRadius;
            }

            set
            {
                if (value < this.Radius)
                {
                    this.innerRadius = value;
                }
            }
        }

        /// <summary>
        /// Calculating area of the ring
        /// </summary>
        /// <returns>Area of the ring</returns>
        public override double Area
        {
            get
            {
                return Math.PI * (Math.Pow(this.Radius, 2) - Math.Pow(this.InnerRadius, 2));
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
                return 2 * Math.PI * this.Radius;
            }
        }
    }
}
