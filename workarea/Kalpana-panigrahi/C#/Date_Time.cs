using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;
          Console.WriteLine("{0:d}", dt);//d is used for short date
         Console.WriteLine("{0:D}", dt);//D is used for short date
         Console.WriteLine("{0:f}", dt);//f is used for full date (short time)
        Console.WriteLine("{0:F}", dt);//F is used for full date (short time) with seconds
         Console.WriteLine("{0:g}", dt);//g is used for general date and time
        
          Console.WriteLine("{0:T}", dt);//d is used for long time
         Console.WriteLine("{0:t}", dt);//D is used for short time
         Console.WriteLine("{0:m}", dt);//d is used for month
         Console.WriteLine("{0:yy}", dt);//D is used for year
         Console.WriteLine("{0:ddd}", dt);//d is used for name of the day of the week
         Console.WriteLine("{0:dddd}", dt);//full name of the day of the week
         
         


    }
}