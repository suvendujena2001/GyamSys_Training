using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //ARITHMETIC OPERATORS
       int a=10, b=5,c=7,d,e,f,g;
         c = a+b;
         d = a-b;
         e = a/b;
         f = a*b;
         g = a%b;
         Console.WriteLine(c);
         Console.WriteLine(d);
         Console.WriteLine(e);
         Console.WriteLine(f);
         Console.WriteLine(g);
         
         //RELATIONAL OPERATORS
         
         bool h = a == b;
         Console.WriteLine(h);
         
         bool i = a != b;
         Console.WriteLine(i);
        
         bool j = a > b;
         Console.WriteLine(j);
         
         bool k = a < b;
         Console.WriteLine(k);
         
         bool l = a >= b;
         Console.WriteLine(l);
         
         bool m = a <= b;
         Console.WriteLine(m);
         
         //LOGOCAL OPERATORS OR CONDITIONAL OPERATORS
         
         bool n = (a>b) && (a<b);
         Console.WriteLine(n);
         
         bool o = (a>b) || (a<b);
         Console.WriteLine(o);
         
         //ASSIGNMENT OPERATORS
         int z = 4;
         z += 1;
         
         // TERNARY OPERATORS
         
         string x = (z>3) ? "z is greater" : "z is smaller";
         Console.WriteLine(x);
         


    }
}