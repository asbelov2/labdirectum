//-----------------------------------------------------------------------
// <copyright file="RemindMeeting.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Meeting
{
    using System;
    using System.Timers;

    /// <summary>
    /// Class that responsible for reminder time
    /// </summary>
    public class RemindMeeting : Meeting, IRemind
    {   
        /// <summary>
        /// Timer that check remind time every minute
        /// </summary>
        private Timer remindTimer;

        /// <summary>
        /// Initializes a new instance of the RemindMeeting class
        /// </summary>
        /// <param name="begin">Begin of the meeting</param>
        /// <param name="end">End of the meeting</param>
        /// <param name="timeBeforeBegin"> Time before beginning for remind </param>
        public RemindMeeting(DateTime begin, DateTime end, TimeSpan timeBeforeBegin) : base(begin, end)
        {
            this.remindTimer = new Timer(TimeSpan.FromMinutes(1).TotalMilliseconds);
            this.remindTimer.Elapsed += this.RemindTimerTick;
            this.remindTimer.Start();
            this.RemindTime = Begin.Subtract(timeBeforeBegin);
        }

        /// <summary>
        /// Remind event handler
        /// </summary>
        /// <param name="message">Remind message</param>
        public delegate void RemindHandler(string message);

        /// <summary>
        /// Remind event
        /// </summary>
        public event RemindHandler Remind;

        /// <summary>
        /// Gets or sets time when the reminder will be triggered
        /// </summary>
        public DateTime RemindTime { get; set; }

        /// <summary>
        /// Method responsible for checking remind time
        /// </summary>
        /// <param name="sender">Object that send</param>
        /// <param name="e">Event arguments</param>
        private void RemindTimerTick(object sender, EventArgs e)
        {
            if (this.RemindTime <= DateTime.Now)
            {
                this.Remind?.Invoke("The time has come");
                this.remindTimer.Stop();
            }
        }
    }
}
