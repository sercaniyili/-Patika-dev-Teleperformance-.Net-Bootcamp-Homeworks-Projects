using Microsoft.AspNetCore.Identity;

namespace Hafta5_Sercaniyili.Entities.Data
{
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime? Birthdate { get; set; }
    }

}
