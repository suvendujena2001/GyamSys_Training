using System;

public class HelloWorld
{
    sealed class Baseclass // we can not inherit the class because it is sealed
    {
        public void show1(){
            Console.WriteLine("Baseclass class method");
        }
    }
    class Derivedclass
    {
        public void show2(){
            Console.WriteLine("Derivedclass class method");
        }
    }
    public static void Main(string[] args)
    {
       
    }
}