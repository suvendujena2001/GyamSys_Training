using System;
using System.Collections;
class Malkist
{
    public static void Main()
    {
        BitArray myBitArr = new BitArray(5);

        myBitArr[0] = true;
        myBitArr[1] = true;
        myBitArr[2] = false;
        myBitArr[3] = true;
        myBitArr[4] = false;
        Console.WriteLine(myBitArr.Get(2));
        Console.WriteLine(myBitArr.Get(3));
    }
}

