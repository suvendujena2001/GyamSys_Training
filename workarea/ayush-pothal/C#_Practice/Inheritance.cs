<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    internal class Program
    {

        // Base class
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        // Single Inheritance
        public class Undergraduate : Student
        {
            public string Program { get; set; }
        }

        // Multilevel Inheritance
        public class Graduate : Undergraduate
        {
            public string Honours { get; set; }
        }

        // Hierarchical Inheritance
        public class PartTimeStudent : Student
        {
            public int HoursOfWork { get; set; }
        }
        static void Main(string[] args)
        {
            //create an undergraduate student
            Undergraduate undergrad = new Undergraduate
            {
                Name = "Ayush",
                Age = 22,
                Program = "Information Technology"
            };

            // Create a graduate student
            Graduate grad = new Graduate
            {
                Name = "Swagat",
                Age = 21,
                Program = "SAP",
                Honours = "SAP Technical"
            };

            // Create a part-time student
            PartTimeStudent partTimeStudent = new PartTimeStudent
            {
                Name = "Subhasish",
                Age = 22,
                HoursOfWork = 12
            };

            Console.WriteLine($"Undergraduate: {undergrad.Name}, Age: {undergrad.Age}, Program: {undergrad.Program}");
            Console.WriteLine($"Graduate: {grad.Name}, Age: {grad.Age}, Thesis: {grad.Honours}");
            Console.WriteLine($"Part-Time Student: {partTimeStudent.Name}, Age: {partTimeStudent.Age}, Work Hours: {partTimeStudent.HoursOfWork}");
            Console.ReadLine();
        }

    }
}

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {

        // Base class
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        // Single Inheritance
        public class Undergraduate : Student
        {
            public string Program { get; set; }
        }

        // Multilevel Inheritance
        public class Graduate : Undergraduate
        {
            public string Honours { get; set; }
        }

        // Hierarchical Inheritance
        public class PartTimeStudent : Student
        {
            public int HoursOfWork { get; set; }
        }
        static void Main(string[] args)
        {
            //create an undergraduate student
            Undergraduate undergrad = new Undergraduate
            {
                Name = "Ayush",
                Age = 22,
                Program = "Information Technology"
            };

            // Create a graduate student
            Graduate grad = new Graduate
            {
                Name = "Swagat",
                Age = 21,
                Program = "SAP",
                Honours = "SAP Technical"
            };

            // Create a part-time student
            PartTimeStudent partTimeStudent = new PartTimeStudent
            {
                Name = "Subhasish",
                Age = 22,
                HoursOfWork = 12
            };

            Console.WriteLine($"Undergraduate: {undergrad.Name}, Age: {undergrad.Age}, Program: {undergrad.Program}");
            Console.WriteLine($"Graduate: {grad.Name}, Age: {grad.Age}, Thesis: {grad.Honours}");
            Console.WriteLine($"Part-Time Student: {partTimeStudent.Name}, Age: {partTimeStudent.Age}, Work Hours: {partTimeStudent.HoursOfWork}");
            Console.ReadLine();
        }

    }
}

>>>>>>> origin/main
