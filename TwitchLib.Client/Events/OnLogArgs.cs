using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Class OnLogArgs.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class OnLogArgs : EntityEventArgs
    {
        /// <summary>
        /// The bot username
        /// </summary>
        public string BotUsername { get; set; }
        /// <summary>
        /// The data
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// The date time
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DateTime { get; set; }
    }
}
