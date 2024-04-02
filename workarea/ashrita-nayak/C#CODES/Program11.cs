using System;
using System.Collections;

Hashtable Seasick = new Hashtable();
Seasick.Add("A1", "milk");
Seasick.Add("A2", "in");
Seasick.Add("A3", "bucket");
Console.WriteLine("Key and Value pairs from Seasick:");
foreach (DictionaryEntry entry in Seasick)
{
    Console.WriteLine($"{entry.Key} and {entry.Value}");
}
Hashtable WavyHair = new Hashtable()
        {
            { 1, "Hare" },
            { 2, "Krishna" },
            { 3, 230.45 },
            { 4, null }
        };
Console.WriteLine("\nKey and Value pairs from WavyHair:");
foreach (var key in WavyHair.Keys)
{
    Console.WriteLine($"{key} and {WavyHair[key]}");
}
