using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Extensions.Attributes.CustomAttributes;

namespace Extensions.Attributes
{
    //oluşturduğum attribute'ları class ve property'ler üzerinde uyguluyorum
    [Table(Name = "Ogrenci")]
    public class Student
    {
        [Column(Name = "id", Type = "int", Required = "zorunlu")]
        public int Id { get; set; }
    }
}
