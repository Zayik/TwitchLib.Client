using System;
using TwitchLib.Client.Models;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Args representing hosting stopped event.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <inheritdoc />
    public class OnHostingStoppedArgs : EntityEventArgs
    {
        /// <summary>
        /// Property representing hosting channel.
        /// </summary>
        public HostingStopped HostingStopped { get; set; }
    }
}
