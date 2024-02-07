using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		/* Datatypes
		int 4bytes
		Long 8bytes
		floating point number 4bytes
		char 2bytes
		boolean 1 bit
		string 2bytes
		  */
	
		int a=34;
		float b=34.4F;
		double c = 34.4D;
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
		/* type casting */
		int x =(int) 3.4;
		double y = x;
		Console.WriteLine(x);
		/*  char to int to long to float to double*/ 
		float varr = Convert.ToInt32(3.55);
		string sx="34 is a number";
		string name=Console.ReadLine();
		Console.WriteLine("Hello"+name);
		Console.ReadLine();
		/* Operators in c#
		Arithmetic Operators
		Assignment operators
		Logical operators
		comparision operators
		*/
		//Arithmetic
		int r=4;
		int s=5;
		Console.WriteLine("The Value of r+s is = " +(r+s));
		Console.WriteLine("The Value of r-s is = " +(r-s));
		Console.WriteLine("The Value of r/s is = " +(r/s));
		Console.WriteLine("The Value of r*s is = " +(r*s));
		Console.ReadLine();
		//Logical Operator
		Console.WriteLine(true||false);
		Console.WriteLine(true&&false);
		Console.WriteLine(false||false);
		Console.WriteLine(true||true);
		Console.ReadLine();
		//Comparision Operator
		Console.WriteLine(23>2);
		Console.WriteLine(23>=2);
		Console.WriteLine(23<=2);
		Console.WriteLine(23==2);
		Console.WriteLine(23!=2);
		Console.ReadLine();
		
		int d= Math.Max(34,345);
		int e= Math.Sqrt(39);
		int t=Math.Abs(-38);
		Console.WriteLine(d);
		Console.ReadLine();