using System.ComponentModel.DataAnnotations;

namespace Hafta5_Sercanİyili.DTOs
{
    public class UserLoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
