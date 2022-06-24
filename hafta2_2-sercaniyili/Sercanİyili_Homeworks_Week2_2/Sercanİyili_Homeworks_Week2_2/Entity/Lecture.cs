using System.ComponentModel.DataAnnotations.Schema;

namespace Sercanİyili_Homeworks_Week2_2.Entity
{
   
    public class Lecture : BaseEntity
    {
        //Navigation Property
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Class> Classes { get; set; }

    }
}
