namespace TwitchLib.Client.Models
{
    /// <summary>
    /// Class representing message data.
    /// </summary>
    public class EntityData
    {
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int EntityId { get; set; }
    }
}
