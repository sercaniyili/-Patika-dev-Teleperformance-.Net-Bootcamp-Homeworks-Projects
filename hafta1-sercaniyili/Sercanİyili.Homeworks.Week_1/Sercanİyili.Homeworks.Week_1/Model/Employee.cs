using System.ComponentModel.DataAnnotations;

namespace Sercanİyili.Homeworks.Week_1.Model
{
    public class Employee 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        [MinLength(2, ErrorMessage = "Minimum lenght is 2")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        [MinLength(2, ErrorMessage = "Minimum lenght is 2")]
        public string Surname { get; set; }
        public string? Gender { get; set; }
        public string City { get; set; }
        public int? Age { get; set; }
        public string? Department { get; set; }

    }
}
