namespace ComplexNumber
{
    using System.Collections;

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
            var twoComplexes = new ArrayList() 
            { 
                new Complex(3,5),
                new Complex(2,2) 
            };
            twoComplexes.Sort();
        }
    }
}
