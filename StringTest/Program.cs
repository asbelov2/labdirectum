namespace StringTest
{
    using System;
    using System.Text;
    using System.Threading;
    using System.Diagnostics;

    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Aruguments of program</param>
        public static void Main(string[] args)
        {
            string A = string.Empty;
            StringBuilder B = new StringBuilder(string.Empty);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for(int i=0;i<100000;i++)
            {
                A = A + "abc";
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
            stopWatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                B.Append("abc");
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);


        }
    }
}
