using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter Your Age");
        string ageStr = Console.ReadLine();
        int age = Convert.ToInt32(ageStr);//convert string to integer
        if(age>18){
            Console.WriteLine("You can Drive");
        }
        else if(age < 10){
            Console.WriteLine("You are too Small to Drive");
        }
        else if(age<75){
            Console.WriteLine("You can Drive");
        }
        else
        {
            Console.WriteLine("You cannot Drive");
        }
    }
}