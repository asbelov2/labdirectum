//-----------------------------------------------------------------------
// <copyright file="Meeting.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ConsoleApp2
{
    using System;

    /// <summary>
    /// Meeting class
    /// </summary>
    public class Meeting
    {
        /// <summary>
        /// Initializes a new instance of the Meeting class
        /// </summary>
        /// <param name="begin">Begin of the meeting</param>
        /// <param name="end">End of the meeting</param>
        public Meeting(DateTime begin, DateTime end)
        {
            this.Begin = begin;
            this.End = end;
        }

        /// <summary>
        /// Gets or sets meeting start time
        /// </summary>
        public DateTime Begin { get; set; }

        /// <summary>
        /// Gets or sets meeting end time
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// Gets duration of meeting
        /// </summary>
        public TimeSpan Duration 
        { 
            get
            {
                return this.End - this.Begin;
            } 
        }
    }
}
