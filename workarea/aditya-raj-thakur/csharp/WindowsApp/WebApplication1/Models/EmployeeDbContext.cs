namespace WebApplication1.Models
{
    public class EmployeeDbContext
    {
        public List<Employee> Employees = new List<Employee>
    {
        new Employee { Id = 1,Name="Avi",Salary=30000,Gender="male",Department=1},
        new Employee { Id = 2,Name="Raj",Salary=20000,Gender="male",Department=2},
        new Employee { Id = 3,Name="Adi",Salary=30000,Gender="male",Department=3},
        new Employee { Id = 4,Name="Abhi",Salary=30000,Gender="male",Department=4}
    };
    }
}
