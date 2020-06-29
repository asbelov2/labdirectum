namespace ComplexNumber
{
    using System;

    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// <param name="args">Aruguments of program</param>
        public static void Main(string[] args)
        {
            Console.WriteLine(Max("1", "22", "333"));
        }

        /// <summary>
        /// Maximum function for 2 params
        /// </summary>
        /// <typeparam name="T">Must be IComparable</typeparam>
        /// <param name="first">First value</param>
        /// <param name="second">Second value</param>
        /// <returns>Max value</returns>
        public static T Max<T>(T first, T second) where T : IComparable
        {
            return (first.CompareTo(second) > 0) ? first : second;
        }

        /// <summary>
        /// Maximum function for 3 params
        /// </summary>
        /// <typeparam name="T">Must be IComparable</typeparam>
        /// <param name="first">First value</param>
        /// <param name="second">Second value</param>
        /// <param name="third">Third value</param>
        /// <returns>Max value</returns>
        public static T Max<T>(T first, T second, T third) where T : IComparable
        {
            return Max<T>(Max<T>(first, second), third);
        }
    }
}
