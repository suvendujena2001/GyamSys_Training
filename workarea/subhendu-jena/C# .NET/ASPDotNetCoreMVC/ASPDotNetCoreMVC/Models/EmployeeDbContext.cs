namespace ASPDotNetCoreMVC.Models
{
    public class EmployeeDbContext
    {
        public EmployeeDbContext()
        {

        }

        public List<Employee> Employees = new List<Employee>
        {
             new Employee { Id =1, Name = "Subhendu", Salary = 50000, Department = "HR", Gender = "Male" },
             new Employee { Id =2, Name = "Swagat", Salary = 60000, Department = "Payroll", Gender = "Male"  },
             new Employee { Id = 3, Name = "Swayam", Salary = 40000, Department = "IT", Gender = "Male" },
             new Employee { Id = 4, Name = "Ayush", Salary = 70000, Department = "Support", Gender = "Male" }
        };
    }
}