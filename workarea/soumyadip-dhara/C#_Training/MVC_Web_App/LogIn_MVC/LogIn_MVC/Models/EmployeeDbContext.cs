using LogIn_MVC.Controllers;

namespace LogIn_MVC.Models
{
    public class EmployeeDbContext
    {
        public List<Employee> employees = new List<Employee> {
            new Employee { Id = 1,Name="Soumyadip",Email="abc@gmail.com",Gender="Male"},
            new Employee { Id = 2,Name="Prince",Email="Prince@gmail.com",Gender="Male"},
              new Employee { Id = 3,Name="Adi",Email="adi@gmail.com",Gender="Male"},
               new Employee { Id = 4,Name="Avi",Email="avi@gmail.com",Gender="Male"},
                new Employee { Id = 5,Name="Abhi",Email="abhi@gmail.com",Gender="Male"}


        };
    }
}
