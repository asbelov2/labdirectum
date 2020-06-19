//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ConsoleApp2
{
    using System;

    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"> Arguments of a program </param>
        public static void Main(string[] args)
        {
            RemindMeeting meeting = new RemindMeeting(DateTime.Now.AddMinutes(5.25), DateTime.Now.AddMinutes(10));
            meeting.Remind += DisplayMessage;
            char exit = 'n';
            while (exit != 'y' && exit != 'Y')
            {
                Console.Clear();
                Console.WriteLine("Type 'Y' to exit");
                exit = (char)Console.Read();
            }
        }

        /// <summary>
        /// This method display text that given in parameter
        /// </summary>
        /// <param name="message">Text for displaying</param>
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
