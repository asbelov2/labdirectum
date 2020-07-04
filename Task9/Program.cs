namespace Task9
{
    using System;
    using System.Collections.Generic;
    using System.IO;
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
            Console.WriteLine("\n5 задание:\n\tReflection1.dll:");
            CreateObject(Path.Combine(Directory.GetCurrentDirectory(), "Reflection1.dll"), "Reflection.Test");
            Console.WriteLine("\tReflection2.dll:");
            CreateObject(Path.Combine(Directory.GetCurrentDirectory(), "Reflection2.dll"), "Reflection.Test");
            Console.ReadLine();
        }

        /// <summary>
        /// This method gets names of all read-write properties
        /// </summary>
        /// <param name="obj">Target object</param>
        /// <returns>Names of properties</returns>

        public static object CreateObject(string assemblyFullPath, string className)
        {
            var asm = Assembly.LoadFrom(assemblyFullPath);
            Type t = asm.GetType(className, true, true);
            PropertyInfo[] properties = t.GetProperties();
            object obj = Activator.CreateInstance(t);
            foreach (var property in properties)
            {
                if (property.CanRead)
                {
                    Console.WriteLine("\t\t"+property.GetValue(obj));
                }
            }

            return obj;
        }
    }
}
