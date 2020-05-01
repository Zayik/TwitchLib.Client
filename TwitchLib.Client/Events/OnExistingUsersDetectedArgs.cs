using System;
using System.Collections.Generic;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Args representing existing user(s) detected event.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <inheritdoc />
    public class OnExistingUsersDetectedArgs : EntityEventArgs
    {
        /// <summary>
        /// Property representing string list of existing users.
        /// </summary>
        public List<string> Users { get; set; }
        /// <summary>
        /// Property representing channel bot is connected to.
        /// </summary>
        public string Channel { get; set; }
    }
}
