using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
   public abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    public class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    internal class AbstractClasses
    {
        public static void Main(string[] args)
        {   
            //Abstract class can't be instantiated
            //The derived classes can be used to instantiate and add values.
            //Animal anm = new Animal();
            Pig myPig = new Pig(); 
            myPig.animalSound();
            myPig.sleep();

            Console.ReadLine();
        }
    }
}
