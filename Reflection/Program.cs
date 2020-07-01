namespace Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// <param name="args">Aruguments of program</param>
        public static void Main(string[] args)
        {
            Test test = new Test("a", "b", "c");
            var props = GetProperties(test);
            foreach (var property in props)
            {
                Console.WriteLine(property);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// This method gets names of all read-write properties
        /// </summary>
        /// <param name="obj">Target object</param>
        /// <returns>Names of properties</returns>
        public static List<string> GetProperties(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            List<string> result = new List<string>();
            foreach (var property in properties)
            {
                if (property.CanRead && property.CanWrite)
                {
                    result.Add(property.Name);
                }
            }

            return result;
        }
    }
}
