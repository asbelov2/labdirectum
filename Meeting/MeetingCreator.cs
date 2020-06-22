namespace Meeting
{
    using System;

    /// <summary>
    ///  Meeting creator class
    /// </summary>
    public abstract class MeetingCreator
    {
        /// <summary>
        /// Initializes a new instance of the Meeting creator class
        /// </summary>
        public MeetingCreator()
        {
        }

        /// <summary>
        /// Creating new instance of the Meeting class
        /// </summary>
        /// <param name="begin"> Begin of meeting time </param>
        /// <param name="end"> End of meeting time </param>
        /// <returns> return instance of the Meeting class </returns>
        public abstract Meeting CreateMeeting(DateTime begin, DateTime end);
    }
}
