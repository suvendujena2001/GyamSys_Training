using System;
using System.Collections;
public class SortreverseArray
{
    public static void Main()
    {
        ArrayList myAL = new ArrayList();
        myAL.Add("I");
        myAL.Add("was");
        myAL.Add("in");
        myAL.Add("New");
        myAL.Add("Jersey");
        myAL.Add("for");
        myAL.Add("a");
        myAL.Add("few");
        myAL.Add("days");
        Console.WriteLine("The ArrayList initially contains the following values:");
        PrintValues(myAL);
        myAL.Sort();
        Console.WriteLine("After sorting in ascending order:");
        PrintValues(myAL);
        myAL.Reverse();
        Console.WriteLine("After reversing:");
        PrintValues(myAL);

    }
    public static void PrintValues(IEnumerable myList)
    {
        foreach (object obj in myList)
            Console.WriteLine("   {0}", obj);
        Console.WriteLine();
    }
}
