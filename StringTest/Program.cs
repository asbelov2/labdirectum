namespace StringTest
{
    using System;
    using System.Diagnostics;
    using System.Text;

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
            string a = string.Empty;
            StringBuilder b = new StringBuilder(string.Empty);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                a += "abc";
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
            stopWatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                b.Append("abc");
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
        }
    }
}
