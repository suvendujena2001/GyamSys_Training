using System;

namespace MyApp
{
    internal class TypeCasting
    {
        public void implicitDisplay() {
            int numInt = 1500;
            //Get type of numInt
            Type numIntType = numInt.GetType();
            // Implicit Conversion
            double numDouble = numInt;
            //Get type of numDouble
            Type numDoubleType = numDouble.GetType();
            // Value Before Conversion
            Console.WriteLine($"numInt value: {numInt}");
            Console.WriteLine($"numInt Type: {numIntType}");
            Console.WriteLine($"Int Size: {sizeof(int)} Bytes");
            // Value After Conversion
            Console.WriteLine($"numDouble value: {numDouble}");
            Console.WriteLine($"numDouble Type: {numDoubleType}");
            Console.WriteLine($"double Size: {sizeof(double)} Bytes");
        }

        public void explicitDisplay() {
            double numDouble = 1.23;
            // Explicit Type Casting
            int numInt = (int)numDouble;
            Console.WriteLine($"Original double Value:{numDouble} and Converted int Value:{numInt}");

            int IntNum1 = 100;
            byte ByteNum1 = (byte)IntNum1; // Explicit Type Casting
            // Printing the Original Value and Converted Value
            Console.WriteLine($"Original Value:{IntNum1} and Converted Value:{ByteNum1}");

            string str = "100";
            int i1 = Convert.ToInt32(str); //Converting string to Integer
            double d = 123.45;
            int i2 = Convert.ToInt32(d); //Converting double to Integer
            float f = 45.678F;
            string str1 = Convert.ToString(f); //Converting float to string
            Console.WriteLine($"Original value str: {str} and Converted Value i1:{i1}");
            Console.WriteLine($"Original value d: {d} and Converted Value i2:{i2}");
            Console.WriteLine($"Original value f: {f} and Converted Value str2:{str1}");

            string str2 = "100";
            //Converting string to int type
            int i = int.Parse(str2);
            Console.WriteLine($"Original String value: {str2} and Converted int value: {i}");
            string str3 = "TRUE";
            //Converting string to boolean type
            bool b = bool.Parse(str3);
            Console.WriteLine($"Original String value: {str3} and Converted bool value: {b}");

            string str4 = "100";
            bool IsConverted1 = int.TryParse(str4, out int I1);
            if (IsConverted1)
            {
                Console.WriteLine($"Original String value: {str4} and Converted int value: {I1}");
            }
            else
            {
                Console.WriteLine($"Try Parse Failed to Convert {str4} to integer");
            }
            string str5 = "Hello";
            bool IsConverted2 = int.TryParse(str5, out int I2);
            if (IsConverted2)
            {
                Console.WriteLine($"Original String value: {str5} and Converted int value: {I2}");
            }
            else
            {
                Console.WriteLine($"Try Parse Failed to Convert {str5} to integer");
            }

        }
      
    }
}
