namespace TwitchLib.Client.Models
{
    /// <summary>Class representing the error that the websocket encountered.</summary>
    public class ErrorEvent : EntityData
    {
        /// <summary>Message pertaining to the error.</summary>
        public string Message { get; set; }
    }
}
