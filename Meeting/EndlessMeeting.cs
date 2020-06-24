namespace Meeting
{
    using System;

    /// <summary>
    /// Endless meeting class
    /// </summary>
    public class EndlessMeeting : Meeting
    {
        /// <summary>
        /// Initializes a new instance of the EndlessMeeting class
        /// </summary>
        /// <param name="begin"> Begin of the meeting </param>
        public EndlessMeeting(DateTime begin) : base(begin, DateTime.MaxValue)
        {
        }

        /// <summary>
        /// Gets meeting duration
        /// </summary>
        public new TimeSpan Duration 
        {
            get
            {
                return TimeSpan.MaxValue;
            } 
        }
    }
}
