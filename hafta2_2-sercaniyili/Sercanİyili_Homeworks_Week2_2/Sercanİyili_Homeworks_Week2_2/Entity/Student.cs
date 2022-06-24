
namespace Sercanİyili_Homeworks_Week2_2.Entity
{
    public class Student : BaseEntity   
    {
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


        //Navigation Property
        public int SchoolId { get; set; }
        public School School { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }
    }

}
