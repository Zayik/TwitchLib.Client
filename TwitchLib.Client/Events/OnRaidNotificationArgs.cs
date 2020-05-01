using System;
using TwitchLib.Client.Models;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Class OnRaidNotificationArgs.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class OnRaidNotificationArgs : EntityEventArgs
    {
        /// <summary>
        /// The raid notification
        /// </summary>
        public RaidNotification RaidNotification { get; set; }
        /// <summary>
        /// The channel
        /// </summary>
        public string Channel { get; set; }
    }
}
