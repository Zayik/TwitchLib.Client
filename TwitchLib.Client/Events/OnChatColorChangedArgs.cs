using System;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Args representing a successful chat color change request.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <inheritdoc />
    public class OnChatColorChangedArgs : EntityEventArgs
    {
        /// <summary>
        /// Property reprenting the channel the event was received in.
        /// </summary>
        public string Channel { get; set; }
    }
}
