
namespace Sercanİyili_Homeworks_Week2_2.Entity
{
    
    public class Class : BaseEntity
    {
        //Navigation Property
        public ICollection<Student> Students { get; set; }
        public ICollection<Lecture> Lectures { get; set; }
    }
}
