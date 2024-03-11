using System;

namespace MyApp
{
    internal class FunctionDemo
    {
        //Either the data type of the parameter or the number of parameters should be different for method overloading
        public void add(int a, int b)
        {
            int sum = a+b;
            Console.WriteLine($"ISum is {sum}");
        }
        public void add(int a, float b)
        {
            float sum = a + b;
            Console.WriteLine($"ifSum is {sum}");
        }
        public void add(float a, float b)
        {
            float sum = a + b;
            Console.WriteLine($"fSum is {sum}");
        }
        public void add(int x, int y, int z)
        {
            Console.WriteLine($"Sum is {x + y + z}");
        }
    }
}
