﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Hafta5_Sercaniyili.Entities.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public ContentType Type { get; set; }

        [ForeignKey("Sender")]
        public AppUser User { get; set; }

        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}
