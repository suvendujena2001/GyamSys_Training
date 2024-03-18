
using System;


class Baseclass
{
    public Baseclass(string msg){
        Console.WriteLine("This is the constructure of base class");
        Console.WriteLine(msg);
        
    }
}
class Derivedclass :  Baseclass
{
   public Derivedclass(): base("Hello")
   {
        Console.WriteLine("This is the constructure of derived class");
   } 
}
class Helloworld{
    public static void Main(string[] args)
    {
        Derivedclass dc = new Derivedclass();
        Console.ReadLine();
    }
}