using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DataTypes dataDisplay=new DataTypes();
            // dataDisplay.displayDataTypes();

            //TypeCasting typeCasting=new TypeCasting();
            //typeCasting.implicitDisplay();
            //typeCasting.explicitDisplay();

            FunctionDemo functionDemo=new FunctionDemo();
            functionDemo.add(5,29);
            functionDemo.add(5, 29.1f);
            functionDemo.add(5.1f, 29.1f);
            functionDemo.add(5, 6,7);

            //Command line arguments
            //Console.WriteLine($"First Command Line Argument {args[0]}");
            //Console.WriteLine($"Second Command Line Argument {args[1]}");
            //Console.WriteLine($"Third Command Line Argument {args[2]}");

            ////convert into integer type
            //int argument1 = Convert.ToInt32(args[3]);
            //Console.WriteLine("Argument in Integer Form : " + argument1);
            ////convert into double type
            //double argument2 = Convert.ToDouble(args[4]);
            //Console.WriteLine("Argument in Double Form : " + argument2);
        }
    }
}