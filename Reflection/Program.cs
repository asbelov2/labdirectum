namespace Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
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
            var test = new Test("A", "B", "C", "D");
            var props = GetProperties(test);
            Console.WriteLine("1 задание:");
            foreach (var property in props)
            {
                Console.WriteLine(property);
            }

            Console.WriteLine("\n2 задание:");
            var obj = CreateObjectAndPrintProperties(Path.Combine(Directory.GetCurrentDirectory(), "MyLib.dll"), "MyLib.Test");   // Неиспользуемая переменная. Пусть метод что-то возвращает, но не обязательно же присваивать результат какой-нибудь переменное.

            Console.WriteLine("\n4 задание:");

            Configuration conf = new Configuration();   // Неиспользуемая переменная.
            var settingsSection = ConfigurationManager.GetSection("ProgramSettings") as Configuration.SettingsSection;
            Console.WriteLine("Parameters:");
            Console.WriteLine("\tIntSetting:\t" + settingsSection.IntSetting);
            Console.WriteLine("\tStrSetting:\t" + settingsSection.StrSetting);
            ConfigurationElementCollection subSettingCollection = settingsSection.SubSettings;
            Console.WriteLine("SubSettings:");
            foreach (Configuration.SubSettingSection subSetting in subSettingCollection)
            {
                Console.WriteLine("\t" + subSetting.SubSetting + ":\t" + subSetting.SubSettingValue);
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
            var type = obj.GetType();
            var properties = type.GetProperties();
            var result = new List<string>();
            foreach (var property in properties)
            {
                if (property.CanRead && property.CanWrite && !Attribute.IsDefined(property, typeof(ObsoleteAttribute)))
                {
                    result.Add("\t" + property.Name + ":\t" + property.GetValue(obj));
                }
            }

            return result;
        }

        /// <summary>
        /// This method create object from given assebly
        /// </summary>
        /// <param name="assemblyFullPath">Full path to assembly</param>
        /// <param name="className">Class name with namespace</param>
        /// <returns>New instance of given class</returns>
        public static object CreateObjectAndPrintProperties(string assemblyFullPath, string className)
        {
            var asm = Assembly.LoadFrom(assemblyFullPath);
            var t = asm.GetType(className, true, false);
            var properties = t.GetProperties();
            var obj = Activator.CreateInstance(t);
            foreach (var property in properties)
            {
                if (property.CanRead)
                {
                    Console.WriteLine(property.GetValue(obj));
                }
            }

            return obj;
        }
    }
}
