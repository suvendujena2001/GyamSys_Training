using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString1= "Hello everyone";
            string myString2 = "Nice to meet you all!";

            //Convert to UpperCase & LowerCase
            Console.WriteLine(myString1.ToUpper());
            Console.WriteLine(myString2.ToLower());


            //Concatenation
            string myString3 = myString1 + myString2;   
            Console.WriteLine(myString3);


            //Interpolation
            string myString4 = $"{myString1} {myString2}";
            Console.WriteLine(myString4);


            //Access Strings
            string name = "Ayush Pothal";
            int pos = name.IndexOf("P");
            string lastName = name.Substring(pos);
            Console.WriteLine(name);
            Console.WriteLine(lastName);
        }
    }
}
