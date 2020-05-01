using System;
using TwitchLib.Client.Exceptions;
using TwitchLib.Client.Models;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Class OnFailureToReceiveJoinConfirmationArgs.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class OnFailureToReceiveJoinConfirmationArgs : EntityData
    {
        /// <summary>
        /// The exception
        /// </summary>
        public FailureToReceiveJoinConfirmationException Exception { get; set; }
    }
}
