namespace Sercanİyili_Homeworks_Week2_2.Entity
{
    public class School : BaseEntity
    {
        public string Email { get; set; }
        
        public string Adress { get; set; }

        //Navigation Property
        public ICollection<Student> Students { get; set; }
    }
}
