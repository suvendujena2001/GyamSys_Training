using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public interface IBrand
    {
        string GetBrand();
    }

    public interface IModel
    {
        void GetModel();
    }

    public class Car : IBrand, IModel
    {
        private string brand;
        private string model;
        private string color;

        public Car(string brand, string model, string color)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
        }

        public string GetBrand()
        {
            return this.brand;
        }

        public void GetModel()
        { 
            Console.WriteLine("Model of Car: "+this.model);
            Console.WriteLine("Colour of Car: "+this.color);
        }
    }

    internal class MultInheritance
    {
            static void Main(string[] args)
            {
                Car Audi = new Car("Audi","audi-R8", "Blue");
                Console.WriteLine("Brand of Car: " + Audi.GetBrand());
                Audi.GetModel();

            Console.ReadLine();
            }
        }
}
