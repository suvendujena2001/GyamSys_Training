## class
A class is simply a user-defined data type that represents both state and behavior. 
The state represents the properties and behavior is the action that objects can perform. 
In other words, we can say that a class is the blueprint/template that describes the details of an object. 
A class is a blueprint from which the individual objects are created. 
In C#, a Class is composed of three things i.e. a name, attributes, and operations.

## Objects:
It is an instance of a class. A class is brought live by creating objects. 
An object can be considered as a thing that can perform activities. 
The set of activities that the object performs defines the object’s behavior. 
All the members of a class can be accessed through the object. 
To access the class members, we need to use the dot (.) operator. 
The dot operator links the name of an object with the name of a member of a class.

## create a Class and Object in C#
To create a class we need to use the class keyword while if we want to create an object of a class then we need to use the new keyword. 
Once we create the object then you we access the class members using the object.

```cs
using System;
namespace ClassObjectsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object
            Calculator calObject = new Calculator();

            //Accessing Calculator class member using Calculator class object
            int result = calObject.CalculateSum(10, 20);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    //Defining class or blueprint or template
    public class Calculator
    {
        public int CalculateSum(int no1, int no2)
        {
            return no1 + no2;
        }
    }
}
```

## Types of class in C#:
- Abstract Class
- Concrete class
- Sealed Class
- Partial Class
- Static Class

## What is a Constructor in C#?
It is a special method present inside a class responsible for initializing the variables of that class.
The name of the constructor method is exactly the same name as the class in which it was present. 
The constructor method does not return any value. That means it is a non-value returning method. 

If we not define constructor in a class then fter compilation, the compiler adds the public constructor 
to the class and initializes the variable and this is the responsibility of a constructor i.e. initializing 
the variables of that class. If a class variable is initialized implicitly means that is done by a constructor.
Every variable we declared inside a class and every field we declared inside a class has a default value. 
All numeric types are initialized with 0, Boolean types initialized with false, and string and object types 
initialized with null.

Implicitly Defined Constructors are parameter less and these constructors are also known as Default Constructors. 
This is because they are used to initialize the variables with default values.
Implicitly Defined Constructors are public. 
We can also define a constructor under the class and if we define it, we can call it an Explicit Constructor and an 
Explicit Constructor can be parameter less and parameterized also.
