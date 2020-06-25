namespace Logger
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
            using (Logger log = new Logger("test.txt"))
            {
                log.WriteString("1");
                log.WriteString("2");
                log.WriteString("3");
            }
            Console.Read();
        }
    }
}
