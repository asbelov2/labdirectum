namespace Maximum
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

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
            List<string> someList = new List<string>() { "3", "222", "11", "4444", string.Empty, "55" };
            Dictionary<int, string> someDictionary = new Dictionary<int, string>() { { 0, "12" }, { 1, "54" }, { 2, "4346" } };
            Console.WriteLine("List:");
            foreach (string item in someList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDictionary:");
            foreach (KeyValuePair<int, string> item in someDictionary)
            {
                Console.WriteLine(item.Key + ". " + item.Value);
            }

            Console.WriteLine("\nMax(\"1\", \"22\", \"333\"):");
            Console.WriteLine(Max("1", "22", "333"));

            Console.WriteLine("\nMax(1,333,22):");
            Console.WriteLine(Max(1,333,22));

            Console.WriteLine("\nText file:");
            using (Text text = new Text("test.txt"))
            {
                foreach (var item in text)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("\nRU");
            Console.WriteLine(strings.E_CANT_CHANGE_PASSWORD_WITH_OS_AUTHENTIFICATION);
            Console.WriteLine(strings.DEBUGGER_MAIN_FORM_TRACE_INTO_ACTION_CAPTION);
            Console.WriteLine("\nEN");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine(strings.E_CANT_CHANGE_PASSWORD_WITH_OS_AUTHENTIFICATION);
            Console.WriteLine(strings.DEBUGGER_MAIN_FORM_TRACE_INTO_ACTION_CAPTION);
        }

        /// <summary>
        /// Maximum function for 2 params
        /// </summary>
        /// <typeparam name="T">Must be IComparable</typeparam>
        /// <param name="first">First value</param>
        /// <param name="second">Second value</param>
        /// <returns>Max value</returns>
        public static T Max<T>(T first, T second) where T : IComparable<T>
        {
            return (first.CompareTo(second) > 0) ? first : second;
        }

        /// <summary>
        /// Maximum function for 3 params
        /// </summary>
        /// <typeparam name="T">Must be IComparable</typeparam>
        /// <param name="first">First value</param>
        /// <param name="second">Second value</param>
        /// <param name="third">Third value</param>
        /// <returns>Max value</returns>
        public static T Max<T>(T first, T second, T third) where T : IComparable<T>
        {
            return Max<T>(Max<T>(first, second), third);
        }
    }
}
