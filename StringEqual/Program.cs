namespace StringEqual
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
            Console.WriteLine(new StringValue("AAA").Equals(new StringValue("AAA")));
            Console.WriteLine(new StringValue("AAA") == new StringValue("AAA"));
        }
    }
}
