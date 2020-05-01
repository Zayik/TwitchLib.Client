using System;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Args representing viewer joined event.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <inheritdoc />
    public class OnUserJoinedArgs : EntityEventArgs
    {
        /// <summary>
        /// Property representing username of joined viewer.
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Property representing channel bot is connected to.
        /// </summary>
        public string Channel { get; set; }
    }
}
