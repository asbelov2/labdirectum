namespace Geometry
{
    using System;

    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Program arguments</param>
        public static void Main(string[] args)
        {
            Ring bigRing = new Ring(1, 5, 20, 17);
            Console.WriteLine("Ring:\n \tOuter radius: " + bigRing.OuterRadius
                            + "\n\tInner radius: " + bigRing.InnerRadius
                            + "\n\tArea: " + bigRing.Area
                            + "\n\tPerimeter: " + bigRing.Perimeter);

            Circle smallCircle = new Circle(0, 3, 5);
            Console.WriteLine("Circle:\n \tRadius: " + smallCircle.Radius
                            + "\n\tArea: " + smallCircle.Area
                            + "\n\tPerimeter: " + smallCircle.Perimeter);

            Square square = new Square(-1, 9, 5.6);
            Console.WriteLine("Square:\n \tSide: " + square.Width 
                            + "\n\tArea: " + square.Area
                            + "\n\tPerimeter: " + square.Perimeter);

            Rectangle doubleSquare = new Rectangle(10, 20, 11.2, 5.6);
            Console.WriteLine("Rectangle:\n \tWidth: " + doubleSquare.Width
                            + "\n\tHeight" + doubleSquare.Height
                            + "\n\tArea: " + doubleSquare.Area
                            + "\n\tPerimeter: " + doubleSquare.Perimeter);
        }
    }
}
