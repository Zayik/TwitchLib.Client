using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.Client.Events
{
    public class EntityEventArgs : EventArgs
    {
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int EntityId { get; set; }
    }
}
