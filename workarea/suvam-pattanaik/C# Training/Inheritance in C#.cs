<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    // base class 

    // single inheritance
    class Animal
    {
        public string name;

        public void display()
        {
            Console.WriteLine("I am an Animal");
        }
    }

    // derived class of Animal 
    class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

    class ParentClass
    {
        public string name;
        public int id ;

        public void displayDetails()
        {
            Console.WriteLine($" I am {name}");
            Console.WriteLine($" ID : {id}");
        }
    }

    // Heirarchical Inheritance
    class ChildClass : ParentClass
    {
        public void getIdFromParent()
        {
            Console.WriteLine("Displaying from first child");
            Console.WriteLine("This is my ID :" + id);
        }
    }

    class AnotherChildClass : ParentClass
    {
        public void getIdFromParent()
        {
            Console.WriteLine("Displaying from other child");
            Console.WriteLine("This is my ID : " + id);
        }
    }

    // multi-level inheritance
    public class Animals
    {
        public void Eat()
        {
            Console.WriteLine("The animal is eating");
        }
    }
    public class Mammal : Animals
    {
        public void Walk()
        {
            Console.WriteLine("The mammal is walking");
        }
    }
    public class Cat : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("The dog is barking");
        }
    }


    //multiple - inheritance 

    interface IShape
    {
        double GetArea();
    }

    interface IColor
    {
        string GetColor();
    }
    class Rectangle : IShape , IColor
    {
        private double length , breadth;
        private string color;

        public Rectangle(double length,double breadth, string color)
        {
            this.length = length;
            this.breadth = breadth;
            this.color = color;
        }

        public double GetArea()
        {
            return length*breadth;
        }

        public string GetColor()
        {
            return color;
        }
        
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //inheritance allows to create new class from an existing class
            // use of : symbol to perform inheritance

            // object of derived class
            Dog labrador = new Dog();

            //access field and method of base class
            labrador.name = "Rohu";
            labrador.display();

            labrador.getName();

            // Single inheritance occurs between two classes - base and derived class.

            Console.WriteLine();
            Console.WriteLine();

            ChildClass child = new ChildClass();
            child.name = "Swayam";
            child.id = 11;

            child.displayDetails();

           // child.getIdFromParent();

            // hierarchical Inheritance 
            // hierarchical inheritance occurs when more than one derived class is created from a single parent class.


            AnotherChildClass anotherChild = new AnotherChildClass();
            anotherChild.id = 1;
            anotherChild.displayDetails();

            // multi-level inheitance 
            // multilevel inheritance occurs when a class is derived from another derived class.


            Cat myCat = new Cat();
            myCat.Eat();
            myCat.Walk();
            myCat.Bark();



            Console.WriteLine();
            Console.WriteLine();

            // multiple-inheritance :
            // Ability of a class to inherit from multiple base classes.
            // C# support multiple-inheritance using interface


            Rectangle rect = new Rectangle(6, 12, "red");
            Console.WriteLine("Area of rectangle is " + rect.GetArea());
            Console.WriteLine("Color of rectangle is :" + rect.GetColor());
            Console.WriteLine();


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

    // base class 

    // single inheritance
    class Animal
    {
        public string name;

        public void display()
        {
            Console.WriteLine("I am an Animal");
        }
    }

    // derived class of Animal 
    class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

    class ParentClass
    {
        public string name;
        public int id ;

        public void displayDetails()
        {
            Console.WriteLine($" I am {name}");
            Console.WriteLine($" ID : {id}");
        }
    }

    // Heirarchical Inheritance
    class ChildClass : ParentClass
    {
        public void getIdFromParent()
        {
            Console.WriteLine("Displaying from first child");
            Console.WriteLine("This is my ID :" + id);
        }
    }

    class AnotherChildClass : ParentClass
    {
        public void getIdFromParent()
        {
            Console.WriteLine("Displaying from other child");
            Console.WriteLine("This is my ID : " + id);
        }
    }

    // multi-level inheritance
    public class Animals
    {
        public void Eat()
        {
            Console.WriteLine("The animal is eating");
        }
    }
    public class Mammal : Animals
    {
        public void Walk()
        {
            Console.WriteLine("The mammal is walking");
        }
    }
    public class Cat : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("The dog is barking");
        }
    }


    //multiple - inheritance 

    interface IShape
    {
        double GetArea();
    }

    interface IColor
    {
        string GetColor();
    }
    class Rectangle : IShape , IColor
    {
        private double length , breadth;
        private string color;

        public Rectangle(double length,double breadth, string color)
        {
            this.length = length;
            this.breadth = breadth;
            this.color = color;
        }

        public double GetArea()
        {
            return length*breadth;
        }

        public string GetColor()
        {
            return color;
        }
        
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //inheritance allows to create new class from an existing class
            // use of : symbol to perform inheritance

            // object of derived class
            Dog labrador = new Dog();

            //access field and method of base class
            labrador.name = "Rohu";
            labrador.display();

            labrador.getName();

            // Single inheritance occurs between two classes - base and derived class.

            Console.WriteLine();
            Console.WriteLine();

            ChildClass child = new ChildClass();
            child.name = "Swayam";
            child.id = 11;

            child.displayDetails();

           // child.getIdFromParent();

            // hierarchical Inheritance 
            // hierarchical inheritance occurs when more than one derived class is created from a single parent class.


            AnotherChildClass anotherChild = new AnotherChildClass();
            anotherChild.id = 1;
            anotherChild.displayDetails();

            // multi-level inheitance 
            // multilevel inheritance occurs when a class is derived from another derived class.


            Cat myCat = new Cat();
            myCat.Eat();
            myCat.Walk();
            myCat.Bark();



            Console.WriteLine();
            Console.WriteLine();

            // multiple-inheritance :
            // Ability of a class to inherit from multiple base classes.
            // C# support multiple-inheritance using interface


            Rectangle rect = new Rectangle(6, 12, "red");
            Console.WriteLine("Area of rectangle is " + rect.GetArea());
            Console.WriteLine("Color of rectangle is :" + rect.GetColor());


            Console.ReadLine();



        }
    }
}
>>>>>>> origin/main
