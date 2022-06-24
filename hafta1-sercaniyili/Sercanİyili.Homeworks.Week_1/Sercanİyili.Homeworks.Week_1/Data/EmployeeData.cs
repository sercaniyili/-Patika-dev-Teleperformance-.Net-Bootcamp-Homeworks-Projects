using Sercanİyili.Homeworks.Week_1.Model;

namespace Sercanİyili.Homeworks.Week_1.Data
{
    public class EmployeeData
    {

       //Model'imden Data oluşturup listeye ekliyorum
       public List<Employee> Employees = new List<Employee>();

        #region
        //public static List<Employee> Employees = new List<Employee>() {
        //        new Employee { Id = 1, Name = "Ali", Surname = "Kazan", Gender = "Erkek", City = "Antalya", Age = 25, Department = "Satış" },
        //        new Employee { Id = 2, Name = "Veli", Surname = "Kazanma", Gender = "Erkek", City = "Mersin", Age = 21, Department = "Muhasebe" },
        //        new Employee { Id = 3, Name = "Ayşe", Surname = "Kazanır", Gender = "Kadın", City = "İstanbul", Age = 30, Department = "Reklam" },
        //        new Employee { Id = 4, Name = "Fatma", Surname = "Kazanamaz", Gender = "Kadın", City = "Ankara", Age = 35, Department = "Temizlik" }

        //};
        #endregion

        private void FillData()
        {
            Employees.AddRange(new List<Employee>
            {
            new Employee { Id = 1, Name = "Ali", Surname = "Kazan", Gender = "Erkek", City = "Antalya", Age = 25, Department = "Satış" },
            new Employee { Id = 2, Name = "Veli", Surname = "Kazanma", Gender = "Erkek", City = "Mersin", Age = 21, Department = "Muhasebe" },
            new Employee { Id = 3, Name = "Ayşe", Surname = "Kazanır", Gender = "Kadın", City = "İstanbul", Age = 30, Department = "Reklam" },
            new Employee { Id = 4, Name = "Fatma", Surname = "Kazanamaz", Gender = "Kadın", City = "Ankara", Age = 35, Department = "Temizlik" },
            new Employee { Id = 5, Name = "Ahmet", Surname = "Kazanacak", Gender = "Erkek", City = "İstanbul", Age = 30, Department = "Reklam" },
            new Employee { Id = 6, Name = "Aycan", Surname = "Kazandibi", Gender = "Kadın", City = "İstanbul", Age = 25, Department = "Reklam" },
            });
        }


        //Singleton design pattern  uyguluyorum
        private static EmployeeData _employeeData = null;

        private EmployeeData()
        {
            FillData();
        }

        public static EmployeeData Singleton
        {
            get
            {
                if (_employeeData == null)
                {
                    _employeeData = new EmployeeData();
                }
                return _employeeData;
            }
        }





    }
}
