namespace Meeting
{
    using System;

    /// <summary>
    /// Meeting with remind creator class
    /// </summary>
    public class RemindMeetingCreator : MeetingCreator
    {
        /// <summary>
        /// Time before beginning for remind
        /// </summary>
        private TimeSpan timeBeforeBegin;

        /// <summary>
        /// Initializes a new instance of the RemindMeeting creator class
        /// </summary>
        /// <param name="timeBeforeBegin"> Time before beginning for remind </param>
        public RemindMeetingCreator(TimeSpan timeBeforeBegin)
        {
            this.timeBeforeBegin = timeBeforeBegin;
        }

        /// <summary>
        /// Creating new instance of the RemindMeeting class
        /// </summary>
        /// <param name="begin"> Begin of meeting time </param>
        /// <param name="end"> End of meeting time </param>
        /// <returns> return instance of the RemindMeeting class </returns>
        public override Meeting CreateMeeting(DateTime begin, DateTime end)
        {
            return new RemindMeeting(begin, end, this.timeBeforeBegin);
        }
    }
}
