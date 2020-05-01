using System;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Args representing whisper sent event.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <inheritdoc />
    public class OnWhisperSentArgs : EntityEventArgs
    {
        /// <summary>
        /// Property representing username of bot.
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Property representing receiver of the whisper.
        /// </summary>
        public string Receiver { get; set; }
        /// <summary>
        /// Property representing sent message contents.
        /// </summary>
        public string Message { get; set; }
    }
}
