//-----------------------------------------------------------------------
// <copyright file="RemindMeeting.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace ConsoleApp2
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
        public RemindMeeting(DateTime begin, DateTime end) : base(begin, end)
        {
            this.remindTimer = new Timer(TimeSpan.FromMinutes(1).TotalMilliseconds);
            this.remindTimer.Elapsed += this.RemindTimer_Tick;
            this.remindTimer.Start();
            this.RemindTime = Begin.Subtract(TimeSpan.FromMinutes(5));
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
        private void RemindTimer_Tick(object sender, EventArgs e) // StyleCop это пропустил, так что пускай, но подчёркиваний в названиях лучше избегать.
        {
            if (this.RemindTime <= DateTime.Now)
            {
                this.Remind?.Invoke("The time has come");
                this.remindTimer.Stop();
            }
        }
    }
}
