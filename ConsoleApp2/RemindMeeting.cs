using System;
using System.Timers;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApp2
{
    class RemindMeeting : Meeting, IRemind
    {
        public Timer remindTimer;
        public RemindMeeting(DateTime begin, DateTime end) : base(begin,end)
        {
            remindTimer = new Timer(TimeSpan.FromMinutes(1).TotalMilliseconds);
            remindTimer.Elapsed += remindTimer_Tick;
            remindTimer.Start();
            RemindTime = Begin.Subtract(TimeSpan.FromMinutes(5));
        }
        private void remindTimer_Tick(object sender, EventArgs e)
        {
            if (RemindTime <= DateTime.Now)
            {
                Remind?.Invoke("The time has come");
                remindTimer.Stop();
            }
        }
        public DateTime RemindTime { get; set;}
        public delegate void RemindHandler(string message);
        public event RemindHandler Remind;
    }
}
