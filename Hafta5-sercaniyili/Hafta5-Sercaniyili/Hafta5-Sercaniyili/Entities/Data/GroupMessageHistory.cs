﻿namespace Hafta5_Sercaniyili.Entities.Data
{
    public class GroupMessageHistory
    {
        public int Id { get; set; }
        public int GroupMessageId { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
