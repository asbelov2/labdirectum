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

            Round commonRound = new Round(10, 10, 10);
            Console.WriteLine("Round:\n \tRadius: " + commonRound.Radius
                            + "\n\tArea: " + commonRound.Area
                            + "\n\tPerimeter: " + commonRound.Perimeter);

            Square square = new Square(-1, 9, 5.6);
            Console.WriteLine("Square:\n \tSide: " + square.Width 
                            + "\n\tArea: " + square.Area
                            + "\n\tPerimeter: " + square.Perimeter);

            Rectangle doubleSquare = new Rectangle(10, 20, 11.2, 5.6);
            Console.WriteLine("Rectangle:\n \tWidth: " + doubleSquare.Width
                            + "\n\tHeight: " + doubleSquare.Height
                            + "\n\tArea: " + doubleSquare.Area
                            + "\n\tPerimeter: " + doubleSquare.Perimeter);

            Triangle rightTriangle = new Triangle(0, 0, 4, 3, 5);
            Console.WriteLine("Triangle:\n \tSide A: " + rightTriangle.SideA
                            + "\n\tSide B: " + rightTriangle.SideB
                            + "\n\tSide C: " + rightTriangle.SideC
                            + "\n\tAngle between A and B: " + rightTriangle.AngleAB.ToString("0.000 Pi")
                            + "\n\tAngle between B and C: " + rightTriangle.AngleBC.ToString("0.000 Pi")
                            + "\n\tAngle between A and C: " + rightTriangle.AngleCA.ToString("0.000 Pi")
                            + "\n\tArea: " + rightTriangle.Area
                            + "\n\tPerimeter: " + rightTriangle.Perimeter);
        }
    }
}
