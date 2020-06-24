namespace LogMethod
{
    using System;
    using System.Globalization;
    using System.IO;

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
            Console.WriteLine(CountRecords("ClientConnectionLog.log", DateTime.ParseExact("04.12.2007", "dd.MM.yyyy", CultureInfo.InvariantCulture), DateTime.ParseExact("14.12.2007", "dd.MM.yyyy", CultureInfo.InvariantCulture)));
            Test testObj = new Test(0, "b", 1, "d");
            Console.WriteLine(testObj.ToString());
        }

        /// <summary>
        /// This method find number of recrod between two dates
        /// </summary>
        /// <param name="fileName">Log file name</param>
        /// <param name="begin">Begin date</param>
        /// <param name="end">End date</param>
        /// <returns>Number of records between begin and end date</returns>
        public static int CountRecords(string fileName, DateTime begin, DateTime end)
        {
            int counter = 0;
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                DateTime date = begin;
                string line = streamReader.ReadLine();
                while (!(streamReader.EndOfStream || date > end))
                {
                    line = streamReader.ReadLine();
                    if (DateTime.TryParseExact(line.Substring(0, "dd.MM.yyyy\thh:mm:ss".Length), "dd.MM.yyyy\tHH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        if ((date >= begin) && (date < end))
                        {
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }
    }
}
