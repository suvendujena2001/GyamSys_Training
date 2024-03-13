using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Classes
    {
        /*        //Declaring an object of type MyClass.
                MyClass mc = new MyClass();

                //Declaring another object of the same type, assigning it the value of the first object.
                MyClass mc2 = mc;*/

        // Creating objects
        //  object1 = new Customer();
        // Although they're sometimes used interchangeably, a class and an object are different things. A class defines a type of object, but it isn't an object itself.An object is a concrete entity based on a class, and is sometimes referred to as an instance of a class.

        /*public class Container
        {
            private int _capacity;

            public Container(int capacity) => _capacity = capacity;
        }*/

        public class Container(int capacity)
        {
            private int _capacity = capacity;
        }
    }
}
