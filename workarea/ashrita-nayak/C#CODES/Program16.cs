using System;
namespace AbstractClass
{
    abstract class Table
    {
protected string name;
        public abstract string Name
        {
            get;
            set;
        }
    }
    class Duster : Table
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Duster obj = new Duster();
            obj.Name = "Classroom - A";
            Console.WriteLine("Name: " + obj.Name);
        }
    }
}
