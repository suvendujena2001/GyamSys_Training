using System;
namespace Leah
{
    class WorkLife
    {
       public string name, location;
        public WorkLife()
        {
            name = "Samantha Ruth";
            location = "Italy";
        }
        public WorkLife(string a, string b)
        {
            name = a;
            location = b;
        }
        }
    class Air
    {
        static void Main(string[] args)
        {
            WorkLife filmAct = new WorkLife();
            Console.WriteLine(filmAct.name);
            Console.WriteLine(filmAct.location);
        }
    }
}