using System;
namespace MyApp1
{
    //Single inheritance and IsA relationship
    public class Rectangle
    {
        public int Length;
        public int Breadth;
        //Member Functions
        public int Area()
        {
            return Length * Breadth;
        }
        public int Perimeter()
        {
            return 2 * (Length + Breadth);
        }

    }

    class Cuboid : Rectangle
    {
        public int Height;
        public Cuboid(int l, int b, int h)
        {
            Length = l;
            Breadth = b;
            Height = h;
        }
        public int Volume()
        {
            return Length * Breadth * Height;
        }
    }

}