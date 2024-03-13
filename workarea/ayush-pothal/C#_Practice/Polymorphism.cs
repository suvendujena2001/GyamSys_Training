<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public virtual void Program()
            {
                Console.WriteLine("Any Program");
            }
        }

        public class Undergraduate : Student
        {
            public override void Program()
            {
                Console.WriteLine("Undergrad Program");
            }
        }

        public class Graduate : Student
        {
            public override void Program()
            {
                Console.WriteLine("Grad Program");
            }
            public string Honours { get; set; }
        }
        static void Main(string[] args)
        {
            Student s1 =new Student();
            Student s2 =new Undergraduate();
            Student s3 =new Graduate();

            s1.Program();
            s2.Program();
            s3.Program();

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

namespace Polymorphism
{
    internal class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public virtual void Program()
            {
                Console.WriteLine("Any Program");
            }
        }

        public class Undergraduate : Student
        {
            public override void Program()
            {
                Console.WriteLine("Undergrad Program");
            }
        }

        public class Graduate : Student
        {
            public override void Program()
            {
                Console.WriteLine("Grad Program");
            }
            public string Honours { get; set; }
        }
        static void Main(string[] args)
        {
            Student s1 =new Student();
            Student s2 =new Undergraduate();
            Student s3 =new Graduate();

            s1.Program();
            s2.Program();
            s3.Program();

            Console.ReadLine();
        }
    }
}
>>>>>>> origin/main
