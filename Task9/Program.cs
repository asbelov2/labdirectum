namespace Task9
{
    using System;
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
            CreateObjectAndPrintProperties(Path.Combine(Directory.GetCurrentDirectory(), "Reflection1.dll"), "Reflection.Test");
            Console.WriteLine("\tReflection2.dll:");
            CreateObjectAndPrintProperties(Path.Combine(Directory.GetCurrentDirectory(), "Reflection2.dll"), "Reflection.Test");
            Console.ReadLine();
        }

        /// <summary>
        /// This method create object from given assebly
        /// </summary>
        /// <param name="assemblyFullPath">Full path to assembly</param>
        /// <param name="className">Class name with namespace</param>
        /// <returns>New instance of given class</returns>

        public static object CreateObjectAndPrintProperties(string assemblyFullPath, string className)
        {
            var asm = Assembly.LoadFile(assemblyFullPath);
            var t = asm.GetType(className, true, true);
            var properties = t.GetProperties();
            var obj = Activator.CreateInstance(t);
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
