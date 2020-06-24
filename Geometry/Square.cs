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
        /// <param name="side">Width of square</param>
        public Square(double x, double y, double side) : base(x, y, side, side)
        {
        }
    }
}
