namespace Geometry
{
    /// <summary>
    /// Shape class
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Initializes a new instance of the Shape class
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public Shape(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or sets X coordinate
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets Y coordinate
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Gets area of the shape
        /// </summary>
        public abstract double Area { get; }

        /// <summary>
        /// Gets perimeter of the shape
        /// </summary>
        public abstract double Perimeter { get; }
    }
}
