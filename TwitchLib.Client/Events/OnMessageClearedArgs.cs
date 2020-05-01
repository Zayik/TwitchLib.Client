using System;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Args representing a cleared message event.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <inheritdoc />
    public class OnMessageClearedArgs : EntityEventArgs
    {
        /// <summary>
        /// Channel that had message cleared event.
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// Message contents that received clear message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Message ID representing the message that was cleared
        /// </summary>
        public string TargetMessageId { get; set; }
    }
}
