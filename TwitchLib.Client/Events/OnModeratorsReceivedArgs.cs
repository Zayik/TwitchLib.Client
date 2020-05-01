using System;
using System.Collections.Generic;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Args representing a list of moderators received from chat.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <inheritdoc />
    public class OnModeratorsReceivedArgs : EntityEventArgs
    {
        /// <summary>
        /// Property representing the channel the moderator list came from.
        /// </summary>
        public string Channel { get; set; }
        /// <summary>
        /// Property representing the list of moderators.
        /// </summary>
        public List<string> Moderators { get; set; }
    }
}
