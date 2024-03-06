using System;
using System.Collections;
 
public class Program
{
    public static void Main()
    {
        // Creating a Hashtable
        Hashtable hashtable = new Hashtable();
 
        // Adding key-value pairs to the Hashtable
        hashtable.Add("1", "One");
        hashtable.Add("2", "Two");
        hashtable.Add("3", "Three");
 
        // Displaying the Hashtable
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
        }
 
        // Removing a key-value pair from the Hashtable
        hashtable.Remove("2");
 
        // Displaying the Hashtable after removal
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
        }
 
        Console.ReadLine();
    }
}