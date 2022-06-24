// See https://aka.ms/new-console-template for more information
using Extensions.Attributes;
using static Extensions.Attributes.CustomAttributes;


//Ago extension method kullanımı
var date = DateTime.Now;
Console.WriteLine(date.Ago());



//oluşturduğum custom attribute uyguladığım sınıftan nesne üretip, attribulerimi deniyorum
Student student = new Student { Id = 1 };

Extension.PropertyAttribute(student);
Extension.ClassAttribute(student);



