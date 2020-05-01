using System;
using TwitchLib.Client.Models;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Class OnAnonGiftedSubscriptionArgs.
    /// Implements the <see cref="EntityEventArgs" />
    /// </summary>
    /// <seealso cref="EntityEventArgs" />
    public class OnAnonGiftedSubscriptionArgs : EntityEventArgs
    {
        /// <summary>
        /// Property representing the information of the gifted subscription.
        /// </summary>
        public AnonGiftedSubscription AnonGiftedSubscription { get; set; }
        /// <summary>
        /// Property representing the Twitch channel this event fired from.
        /// </summary>
        public string Channel { get; set; }
    }
}