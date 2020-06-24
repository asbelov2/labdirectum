namespace Meeting
{
    using System;

    /// <summary>
    /// Typed meeting class
    /// </summary>
    public class TypedMeeting : Meeting
    {
        /// <summary>
        /// Type of the meeting
        /// </summary>
        private MeetingType type; // Лушче сделать свойством только для чтения, чтобы его можно было посмотреть из вне.

        /// <summary>
        /// Initializes a new instance of the TypedMeeting class
        /// </summary>
        /// <param name="begin">Begin of the meeting</param>
        /// <param name="end">End of the meeting</param>
        /// <param name="type">Type of the meeting</param>
        public TypedMeeting(DateTime begin, DateTime end, MeetingType type) : base(begin, end)
        {
            this.type = type;
        }

        /// <summary>
        /// Types of meeting
        /// </summary>
        public enum MeetingType
        {
            /// <summary>
            /// 0 Совещание
            /// </summary>
            Session,

            /// <summary>
            /// 1 Поручение
            /// </summary>
            Instruction,

            /// <summary>
            /// 2 Звонок
            /// </summary>
            Call,

            /// <summary>
            /// 3 День рождения
            /// </summary>
            Birthday    
        }
    }
}
