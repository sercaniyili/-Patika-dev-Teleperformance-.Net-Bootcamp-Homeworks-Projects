using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Extensions.Attributes.CustomAttributes;

namespace Extensions.Attributes
{
    public static class Extension
    {
        //verilen tarihe kaç gün uzaklıkta olduğunu gösteren bir extension method
        public static string Ago(this DateTime date)
        {
            DateTime date1 = new DateTime(2022, 5, 24);

            TimeSpan span = date1.Subtract(date).Duration();

            var sb = new StringBuilder();

            sb.Append($" {span.Days.ToString()} gün {span.Hours.ToString()} saat {span.Minutes.ToString()} dakika önce");

            return sb.ToString();
        }


        //properyleri kontrol ederek, oluşturduğum ColumnAttribute'u bularak attribute'un yapacağı işlemleri yaptırıyorum.
        public static void PropertyAttribute(object student)
        {
            Type type = student.GetType();

            foreach (PropertyInfo info in type.GetProperties())
            {
                foreach (object item in info.GetCustomAttributes())
                {
                    if (item is ColumnAttribute)
                    {
                        var Column = item as ColumnAttribute;
                        Console.WriteLine($"kolonları : {Column.Name}   tipi : {Column.Type}    {Column.Required}");

                    }
                }

            }
            #region
            //object[] attr = type.GetCustomAttributes(typeof(ColumnAttribute), true);

            //foreach (object item in attr)
            //{
            //    if (item is ColumnAttribute)
            //    {
            //        ColumnAttribute Column = (ColumnAttribute)item;
            //        Console.WriteLine($"kolonları : {Column.Name}   tipi : {Column.Type}    {Column.Required}");
            //    }
            //}


            //object[] attr = type.GetCustomAttributes(typeof(ColumnAttribute), true);

            //if (attr.Length > 0)
            //{
            //    foreach (var item in attr)
            //    {
            //        var ColumnAttribute = (ColumnAttribute)item;    
            //        var value = item.GetValue();
            //    }
            //}
            #endregion
        }

        //properyleri kontrol ederek, oluşturduğum TableAttribute'u bularak attribute'un yapacağı işlemleri yaptırıyorum.
        public static void ClassAttribute(object student)
        {
            Type type = student.GetType();
            var attr = type.GetCustomAttributes().ToList();

            if (attr.Count > 0)
            {
                foreach (var obj in attr)
                {
                    if (obj is TableAttribute)
                    {
                        var Table = obj as TableAttribute;

                        string TableName = Table.Name;
                        string[] Letters = new[] { "ğ", "ç", "ş", "ü", "ö", "ı", "Ğ", "Ç", "Ş", "Ü", "Ö", "İ" };

                        bool ContainsSpacialCharacter = TableName.Any(x => !char.IsLetterOrDigit(x));
                        bool ContainsTurkishCharacter = Letters.Any(TableName.Contains);

                        if (ContainsSpacialCharacter || ContainsTurkishCharacter)
                            Console.WriteLine("Tablo ismi özel veya Türkçe karakter içeriyor");
                        else
                            Console.WriteLine("Tablo Adı : " + Table.Name);

                    }
                }
            }
        }

    }


}
