﻿using System;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Args representing moderator leave event.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <inheritdoc />
    public class OnModeratorLeftArgs : EntityEventArgs
    {
        /// <summary>
        /// Property representing username of moderator that left..
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Property representing channel bot is connected to.
        /// </summary>
        public string Channel { get; set; }
    }
}
