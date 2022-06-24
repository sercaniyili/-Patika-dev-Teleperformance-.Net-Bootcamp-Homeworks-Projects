using System.ComponentModel.DataAnnotations.Schema;

namespace Hafta5_Sercaniyili.Entities.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ContentType Type { get; set; }
        public DateTime SendDate { get; set; }

        [ForeignKey("Sender")]
        public AppUser User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
