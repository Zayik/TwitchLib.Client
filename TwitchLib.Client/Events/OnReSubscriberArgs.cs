using System;
using TwitchLib.Client.Models;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Args representing resubscriber event.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <inheritdoc />
    public class OnReSubscriberArgs : EntityEventArgs
    {
        /// <summary>
        /// Property representing resubscriber object.
        /// </summary>
        public ReSubscriber ReSubscriber { get; set; }
        /// <summary>
        /// Property representing the Twitch channel this event fired from.
        /// </summary>
        public string Channel { get; set; }
    }
}
