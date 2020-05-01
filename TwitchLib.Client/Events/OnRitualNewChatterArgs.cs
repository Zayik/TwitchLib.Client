using System;
using TwitchLib.Client.Models;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Class OnRitualNewChatterArgs.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class OnRitualNewChatterArgs : EntityEventArgs
    {
        /// <summary>
        /// The ritual new chatter
        /// </summary>
        public RitualNewChatter RitualNewChatter { get; set; }
    }
}
