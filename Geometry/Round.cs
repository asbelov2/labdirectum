namespace Geometry
{
    /// <summary>
    /// Round class
    /// </summary>
    public abstract class Round : Shape
    {
        /// <summary>
        /// Initializes a new instance of the Round class
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="radius">Outer radius</param>
        public Round(double x, double y, double radius) : base(x, y)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets outer radius
        /// </summary>
        public double Radius { get; set; }
    }
}
