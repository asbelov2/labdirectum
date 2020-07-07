namespace LogFilter
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

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
            var sortedTxt = GetSortedByDateLog("Log.txt");
            foreach (var str in sortedTxt)
            {
                Console.WriteLine(str);
            }
        }

        /// <summary>
        /// Sorting log by date
        /// </summary>
        /// <param name="path">Path to log</param>
        /// <returns>sorted by date log</returns>
        public static List<string> GetSortedByDateLog(string path)
        {
            var text = new Text(path);
            DateTime date = new DateTime();
            var sortedLog = text.Where(t => DateTime.TryParseExact(t.Substring(0, "dd.MM.yyyy hh:mm:ss".Length), "dd.MM.yyyy hh:mm:ss", null, DateTimeStyles.None, out date))
                .OrderBy(t => DateTime.Parse(t.Substring(0, "dd.MM.yyyy hh:mm:ss".Length)));
            return sortedLog.ToList();
        }
    }
}
