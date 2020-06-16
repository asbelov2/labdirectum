//-----------------------------------------------------------------------
// <copyright file="IRemind.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace ConsoleApp2
{
    using System;
    interface IRemind
    {
        /// <summary>
        /// Gets or sets time when the reminder will be triggered
        /// </summary>
        DateTime RemindTime {get; set;}
    }
}
