namespace CoreMVC_Practice.Models
{
    public class EmployeeDbContext
    {


        public List<Employee> Employees = new List<Employee>
    {
        new Employee { Id = 1,Name="Avinash",Salary=30000,Gender="male",Department=1},
        new Employee { Id = 2,Name="Raja",Salary=20000,Gender="male",Department=2},
        new Employee { Id = 3,Name="Rani",Salary=30100,Gender="female",Department=3},
        new Employee { Id = 4,Name="Priya",Salary=30000,Gender="female",Department=1},
    };
    }
}
