using System;

public class HelloWorld
{
    class Employee{
       private int[] Age = new int[3];
       public int this[int index]{
           set{
               Age[index]=value;
           }
           get{
               return Age[index];
           }
       }
    }
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp[0]= 5;
        Console.WriteLine (emp[0]);
    }
}