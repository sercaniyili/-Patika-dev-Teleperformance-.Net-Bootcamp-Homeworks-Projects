using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Extensions.Attributes.CustomAttributes;

namespace Extensions.Attributes
{
    public class CustomAttributes
    {
        //custom attribute'ları oluşturuyorum
        [AttributeUsage(AttributeTargets.Class)]
        public class TableAttribute : Attribute
        {
            public string Name { get; set; }
        }

        [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
        public class ColumnAttribute : Attribute
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Required { get; set; }

        }
    }
}

