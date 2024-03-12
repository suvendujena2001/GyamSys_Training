using System;
using System.Collections;
class Arraylist
{
    static void Main()
    {
        // Creating an ArrayList
        ArrayList list = new ArrayList();

        // Adding elements to an ArrayList
        list.Add(1);
        list.Add(2.5);
        list.Add("Hello");

        // Accessing elements of an ArrayList
        Console.WriteLine(list[0]); // Output: 1
        Console.WriteLine(list[2]); // Output: Hello

        // Modifying elements of an ArrayList
        list[1] = 3.14;
        Console.WriteLine(list[1]); // Output: 3.14

        // Inserting an element into an ArrayList
        list.Insert(0, "World");
        Console.WriteLine(list[0]); // Output: World

        // Removing an element from an ArrayList
        list.RemoveAt(2);
        Console.WriteLine(list.Count); // Output: 3

        // Using a for loop to iterate over an ArrayList
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.ReadLine();
    }
}

//Sorting an arraylist
list.Sort();
foreach (var item in list)
{
    Console.WriteLine(item);
}

//reversing an array list
list.Reverse();
foreach (var item in list)
{
    Console.WriteLine(item);
}
