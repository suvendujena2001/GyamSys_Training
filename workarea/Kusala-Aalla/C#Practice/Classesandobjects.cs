using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classesandobjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car sportsCarObject = new Car();
            Car van = new Car();

            var carName = sportsCarObject.CarName("Sports Car");

            var varName = van.CarName("Van");

            Console.WriteLine(carName);
            Console.WriteLine(varName);
            Console.ReadLine();
        }
    }
    class Car
    {
        public string CarName(string carType)
        {
            return $"This is a {carType}";
        }
    }
}
