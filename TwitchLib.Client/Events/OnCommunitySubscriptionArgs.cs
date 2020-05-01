using TwitchLib.Client.Models;

namespace TwitchLib.Client.Events
{
    /// <summary>
    /// Class OnCommunitySubscriptionArgs.
    /// </summary>
    public class OnCommunitySubscriptionArgs : EntityData
    {
        public int Id { get; set; }

        /// <summary>
        /// Property representing the information of the community subscription.
        /// </summary>
        public CommunitySubscription GiftedSubscription { get; set; }
        /// <summary>
        /// Property representing the Twitch channel this event fired from.
        /// </summary>
        public string Channel { get; set; }
    }
}
