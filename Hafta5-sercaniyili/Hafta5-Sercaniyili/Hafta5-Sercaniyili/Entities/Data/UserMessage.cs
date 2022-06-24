﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Hafta5_Sercaniyili.Entities.Data
{
    public class UserMessage
    {
        public int Id { get; set; }
        [ForeignKey("Sender")]
        public AppUser User { get; set; }
        [ForeignKey("Reciever")]
        public AppUser Friend { get; set; }
        public DateTime SendDate { get; set; }
        public ContentType Type { get; set; }
        public string Content { get; set; }
    }
}
