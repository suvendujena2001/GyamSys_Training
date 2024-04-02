using System;
using System.Collections;

class Homework2
{
    static void Main()
    {
        ArrayList arlist = new ArrayList();
        arlist.Add(24);
        arlist.Add("Malayalam");
        arlist.Add("Roots");
        arlist.Add(4.5f);
        int firstElement = (int)arlist[0]; 
        string secondElement = (string)arlist[1]; 

        // Update elements
        arlist[0] = "Khwahish Channa"; 
        arlist[1] = 231; 
        Console.WriteLine("Updated ArrayList:");
        foreach (var item in arlist)
        {
            Console.WriteLine(item);
        }
    }
}
