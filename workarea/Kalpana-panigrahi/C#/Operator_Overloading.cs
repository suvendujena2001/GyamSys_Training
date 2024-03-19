
using System;

public class HelloWorld
{
    class newclass{
        public string str;
        public int num;
        
        public static newclass operator +(newclass obj1, newclass obj2){
            newclass obj3 = new newclass();
            obj3.str = obj1.str + obj2.str;
            obj3.num = obj1.num + obj2.num;
            return obj3;
        }
        
    }
    public static void Main(string[] args)
    {
        Console.WriteLine ("Kalpana" + "Panigrahi");//+ is used for concatenation
         Console.WriteLine(5+7); // + is used for addition
         newclass obj1 = new newclass();
         obj1.str = "Kalpana";
         obj1.num = 21;
         newclass obj2 = new newclass();
         obj2.str = "Panigrahi";
         obj2.num = 20;
         newclass obj3 = new newclass();
         obj3 = obj1+obj2;
         Console.WriteLine(obj3.str);
         Console.WriteLine(obj3.num);
         
        
    }
}