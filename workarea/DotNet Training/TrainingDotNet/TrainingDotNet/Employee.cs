using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDotNet
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {

        }
        public Employee(int empId, string fName, string sName)
        {
            EmpId = empId;
            FirstName = fName;
            LastName = sName;
        }

        public Employee(int empId)
        {
            EmpId = empId;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        ~Employee()
        {

        }
    }

}
