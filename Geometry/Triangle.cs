namespace Geometry
{
    using System;

    /// <summary>
    /// Triangle class
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the Triangle class
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="sideA">First side</param>
        /// <param name="sideB">Second side</param>
        /// <param name="sideC">Third side</param>
        public Triangle(double x, double y, double sideA, double sideB, double sideC) : base(x, y)
        {
            if ((sideA + sideB > sideC) &&
                 (sideB + sideC > sideA) &&
                 (sideC + sideA > sideB))
            {
                this.SideA = sideA;
                this.SideB = sideB;
                this.SideC = sideC;
            }
            else
            {
                throw new Exception("Wrong sides of triangle");
            }
        }

        /// <summary>
        /// Gets or sets first side
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// Gets or sets second side
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// Gets or sets third side
        /// </summary>
        public double SideC { get; set; }

        /// <summary>
        /// Gets or sets angle between A and B sides
        /// </summary>
        public double AngleAB
        {
            get
            {
                return Math.Acos((Math.Pow(this.SideA, 2) + Math.Pow(this.SideB, 2) - Math.Pow(this.SideC, 2)) / (2 * this.SideA * this.SideB));
            }
        }

        /// <summary>
        /// Gets or sets angle between A and B sides
        /// </summary>
        public double AngleBC
        {
            get
            {
                return Math.Acos((Math.Pow(this.SideB, 2) + Math.Pow(this.SideC, 2) - Math.Pow(this.SideA, 2)) / (2 * this.SideB * this.SideC));
            }
        }

        /// <summary>
        /// Gets or sets angle between A and B sides
        /// </summary>
        public double AngleCA
        {
            get
            {
                return Math.Acos((Math.Pow(this.SideC, 2) + Math.Pow(this.SideA, 2) - Math.Pow(this.SideB, 2)) / (2 * this.SideA * this.SideC));
            }
        }

        /// <summary>
        /// Calculating perimeter of the rectangle
        /// </summary>
        /// <returns>Perimeter of the rectangle</returns>
        public override double Perimeter
        {
            get
            {
                return this.SideA + this.SideB + this.SideC;
            }
        }

        /// <summary>
        /// Calculating area of the rectangle
        /// </summary>
        public override double Area
        {
            get
            {
                return this.SideA * this.SideB * Math.Sin(this.AngleAB) / 2;
            }
        }
    }
}
