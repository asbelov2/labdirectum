namespace DateAndNumbersFormat
{
    using System;
    using System.Data;

    public enum DateFormatType
    {
        /// <summary>
        /// 13.03.1993
        /// </summary>
        OnlyNumbers = 1,

        /// <summary>
        /// 13.03.93
        /// </summary>
        OnlyNumbersShort = 2,

        /// <summary>
        /// 13 March 1993
        /// </summary>
        WithWords = 3,

        /// <summary>
        /// 13 Mar 1993
        /// </summary>
        WithWordsShort = 4,

        /// <summary>
        /// 03.13.1996
        /// </summary>
        USNumbers = 5,
        
        /// <summary>
        /// March 13, 1993
        /// </summary>
        USWords = 6,
        
        /// <summary>
        /// 1993.03.13
        /// </summary>
        ChinaNumber = 7,

        /// <summary>
        /// 13 March 1993 17:04:43
        /// </summary>
        DateWithTime = 8,

        /// <summary>
        /// 17:04:43
        /// </summary>
        OnlyTime = 9,

        /// <summary>
        /// 13.03.1993 17:04:43
        /// </summary>
        DateWithTimeShort = 10
    }

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
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(FormatDate(DateTime.Now, (DateFormatType)i));
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
            string result = "";
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

        public static string FormatNumber()
        {
            string result = "";
            return result;
        }
    }
}
