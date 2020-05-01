using System;
using System.Linq;
using TwitchLib.Client.Models.Internal;

namespace TwitchLib.Client.Models
{
    public class BeingHostedNotification : EntityData
    {
        public string BotUsername { get; protected set; }

        public string Channel { get; protected set; }

        public string HostedByChannel { get; protected set; }

        public bool IsAutoHosted { get; protected set; }

        public int Viewers { get; protected set; }

        public BeingHostedNotification() { }

        public BeingHostedNotification(string botUsername, IrcMessage ircMessage)
        {
            Channel = ircMessage.Channel;
            BotUsername = botUsername;
            HostedByChannel = ircMessage.Message.Split(' ').First();

            if(ircMessage.Message.Contains("up to "))
            {
                var splt = ircMessage.Message.Split(new string[] { "up to " }, StringSplitOptions.None);
                if(splt[1].Contains(" ") && int.TryParse(splt[1].Split(' ')[0], out int n))
                    Viewers = n;
            }

            if(ircMessage.Message.Contains("auto hosting"))
                IsAutoHosted = true;
        }

        public BeingHostedNotification(
            string channel,
            string botUsername,
            string hostedByChannel,
            int viewers,
            bool isAutoHosted)
        {
            Channel = channel;
            BotUsername = botUsername;
            HostedByChannel = hostedByChannel;
            Viewers = viewers;
            IsAutoHosted = isAutoHosted;
        }
    }
}
