namespace Geometry
{
    /// <summary>
    /// Rectangle class
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the Rectangle class
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="width">Width of rectangle</param>
        /// <param name="height">Height of rectangle</param>
        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets width
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets height
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Calculating perimeter of the rectangle
        /// </summary>
        /// <returns>Perimeter of the rectangle</returns>
        public override double Perimeter
        {
            get
            {
                return (2 * this.Width) + (2 * this.Height);
            }
        }

        /// <summary>
        /// Calculating area of the rectangle
        /// </summary>
        public override double Area
        {
            get
            {
                return this.Width * this.Height;
            }
        }
    }
}
