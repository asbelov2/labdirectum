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

        // Ещё было бы не плохо переопределить Duration.
    }
}
