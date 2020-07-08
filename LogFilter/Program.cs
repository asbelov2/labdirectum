namespace LogFilter
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
            var sortedTxt = GetSortedByDateLog("Log.txt", DateTime.Parse("10.05.1965"));
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
        public static List<string> GetSortedByDateLog(string path, DateTime date)
        {
            const string datePattern = "dd.MM.yyyy hh:mm:ss";
            var text = new Text(path);
            var sortedLog = text
                .Where(t => DateTime.TryParseExact(t.Substring(0, datePattern.Length), datePattern, null, DateTimeStyles.None, out var date))
                .OrderBy(t => DateTime.Parse(t.Substring(0, datePattern.Length)))
                .Where(t => DateTime.Parse(t.Substring(0, datePattern.Length)).Date == date);
            return sortedLog.ToList();
        }
    }
}
