namespace Geometry
{
    /// <summary>
    /// Square class
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// Initializes a new instance of the Square class
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="width">Width of rectangle</param>
        public Square(double x, double y, double width) : base(x, y, width, width)
        {
        }
    }
}
