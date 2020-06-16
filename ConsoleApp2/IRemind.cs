﻿//-----------------------------------------------------------------------
// <copyright file="IRemind.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace ConsoleApp2
{
    using System;

    /// <summary>
    /// Remind interface
    /// </summary>
    public interface IRemind
    {
        /// <summary>
        /// Gets or sets time when the reminder will be triggered
        /// </summary>
        DateTime RemindTime { get; set; }
    }
}
