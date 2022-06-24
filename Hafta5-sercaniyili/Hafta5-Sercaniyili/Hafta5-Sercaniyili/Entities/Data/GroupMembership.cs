namespace Hafta5_Sercaniyili.Entities.Data
{
    public class GroupMembership
    {
        public int Id { get; set; }

        public AppUser GroupMember { get; set; }
        public int GroupMemberId { get; set; }

        public Group Group { get; set; }
        public int GroupId { get; set; }


    }
}
