using System;
					
public class Program
{
	public static void Main()
	{
		string hello = "Hello this is a c code";
        Console.WriteLine(hello.Length);
        Console.WriteLine(hello.ToUpper());
		//String interpolation
		string name= Console.ReadLine();
		string candies = Console.ReadLine();
		Console.WriteLine($"Your name is {name}. You will get {candies} candies.");
		Console.ReadLine();
		//access the string
		string hlo = "hello i am kalpana";
		Console.WriteLine(hlo[1]);
		Console.WriteLine(hlo.IndexOf('h'));
		Console.WriteLine(hlo.IndexOf("hello"));
		// Substring methode
		Console.WriteLine(hlo.Substring((3));
		/* \n is used for ne line
		\t is used for new tab
		\" is used for insert " */
		
		
		
		
	}
}