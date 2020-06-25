namespace DateAndNumbersFormat
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Format of real numbers
    /// </summary>
    public enum NumberFormatType
    {
        /// <summary>
        /// Defualt presentation of number
        /// </summary>
        Default = 0,

        /// <summary>
        /// Number with dot as delimiter
        /// </summary>
        Dot = 1,

        /// <summary>
        /// Number with E in the end
        /// </summary>
        Exp = 2,

        /// <summary>
        /// Numbers separeted by ',' every 3 digits in integer part
        /// </summary>
        Bank = 3
    }

    /// <summary>
    /// Format of date
    /// </summary>
    public enum DateFormatType
    {
        /// <summary>
        /// Looks like 13.03.1993
        /// </summary>
        OnlyNumbers = 1,

        /// <summary>
        /// Looks like 13.03.93
        /// </summary>
        OnlyNumbersShort = 2,

        /// <summary>
        /// Looks like 13 March 1993
        /// </summary>
        WithWords = 3,

        /// <summary>
        /// Looks like 13 Mar 1993
        /// </summary>
        WithWordsShort = 4,

        /// <summary>
        /// Looks like 03.13.1996
        /// </summary>
        USNumbers = 5,

        /// <summary>
        /// Looks like March 13, 1993
        /// </summary>
        USWords = 6,

        /// <summary>
        /// Looks like 1993.03.13
        /// </summary>
        ChinaNumber = 7,

        /// <summary>
        /// Looks like 13 March 1993 17:04:43
        /// </summary>
        DateWithTime = 8,

        /// <summary>
        /// Looks like 17:04:43
        /// </summary>
        OnlyTime = 9,

        /// <summary>
        /// Looks like 13.03.1993 17:04:43
        /// </summary>
        DateWithTimeShort = 10
    }

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
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(FormatDate(DateTime.Now, (DateFormatType)i));
            }

            Console.WriteLine();

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(FormatNumber(1234567890.1234, (NumberFormatType)i));
            }
        }

        /// <summary>
        /// Method transform date into format that needed
        /// </summary>
        /// <param name="date">Target date</param>
        /// <param name="ftype">Format type</param>
        /// <returns>Formated date</returns>
        public static string FormatDate(DateTime date, DateFormatType ftype)
        {
            string result = string.Empty;
            switch (ftype)
            {
                case DateFormatType.OnlyNumbers:
                    result = date.ToString("dd.MM.yyyy");
                    break;
                case DateFormatType.OnlyNumbersShort:
                    result = date.ToString("dd.MM.yy");
                    break;
                case DateFormatType.WithWords:
                    result = date.ToString("dd MMMM yyyy");
                    break;
                case DateFormatType.WithWordsShort:
                    result = date.ToString("dd MMM yyyy");
                    break;
                case DateFormatType.USNumbers:
                    result = date.ToString("MM.dd.yyyy");
                    break;
                case DateFormatType.USWords:
                    result = date.ToString("MMMM dd, yyyy");
                    break;
                case DateFormatType.ChinaNumber:
                    result = date.ToString("yyyy.MM.dd");
                    break;
                case DateFormatType.DateWithTime:
                    result = date.ToString("F");
                    break;
                case DateFormatType.OnlyTime:
                    result = date.ToString("T");
                    break;
                case DateFormatType.DateWithTimeShort:
                    result = date.ToString("G");
                    break;
            }    

            return result;
        }

        /// <summary>
        /// Present number in needed format
        /// </summary>
        /// <param name="number">Target number</param>
        /// <param name="ftype">Type of format</param>
        /// <returns>Formated string</returns>
        public static string FormatNumber(double number, NumberFormatType ftype)
        {
            string result = string.Empty;
            switch (ftype)
            {
                case NumberFormatType.Dot:
                    result = number.ToString(CultureInfo.InvariantCulture);
                    break;
                case NumberFormatType.Exp:
                    result = number.ToString("0.####E+0");
                    break;
                case NumberFormatType.Bank:
                    result = number.ToString("0,0.###", CultureInfo.InvariantCulture);
                    break;
                default:
                    result = number.ToString();
                    break;
            }

            return result;
        }
    }
}
