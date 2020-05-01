﻿using System;
using TwitchLib.Client.Models;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Class OnWhisperReceivedArgs.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <inheritdoc />
    public class OnWhisperReceivedArgs : EntityEventArgs
    {
        /// <summary>
        /// The whisper message
        /// </summary>
        public WhisperMessage WhisperMessage { get; set; }
    }
}
