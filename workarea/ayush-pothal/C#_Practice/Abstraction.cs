<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        abstract class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public abstract void Program();
        }

         class Undergraduate : Student
        {
            public override void Program()
            {
                Console.WriteLine("Undergrad Program");
            }
        }

        static void Main(string[] args)
        {
            Undergraduate undergraduate = new Undergraduate();
            undergraduate.Program();
            undergraduate.Name = "Ayush";
            Console.WriteLine(undergraduate.Name);
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

namespace Abstract
{
    internal class Program
    {
        abstract class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public abstract void Program();
        }

         class Undergraduate : Student
        {
            public override void Program()
            {
                Console.WriteLine("Undergrad Program");
            }
        }

        static void Main(string[] args)
        {
            Undergraduate undergraduate = new Undergraduate();
            undergraduate.Program();
            undergraduate.Name = "Ayush";
            Console.WriteLine(undergraduate.Name);
            Console.ReadLine();
        }
    }
}
>>>>>>> origin/main
