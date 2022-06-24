namespace Sercanİyili_Homeworks_Week2_2.Entity
{
    public class Teacher : BaseEntity
    {
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        //Navigation Property
        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }
    }
}
