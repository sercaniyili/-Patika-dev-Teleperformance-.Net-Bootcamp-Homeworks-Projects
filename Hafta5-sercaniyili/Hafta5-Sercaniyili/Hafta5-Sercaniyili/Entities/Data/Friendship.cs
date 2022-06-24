using System.ComponentModel.DataAnnotations.Schema;

namespace Hafta5_Sercaniyili.Entities.Data
{
    public class Friendship
    {
        public int Id { get; set; }

        [ForeignKey("Sender")]
        public AppUser User { get; set; }

        [ForeignKey("Reciever")]
        public AppUser Friend { get; set; }

        public FriendshipStatus Status { get; set; }
    }
}
