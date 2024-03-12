using System;
using System.Collections;
using System.Collections.Generic;
Console.WriteLine("Hello, World!");
ArrayList ar = new ArrayList();
ar.Add(1);
ar.Add(2);
ar.Add(null);
ar.Add('1');
ar.Add("12");
ar.Add("cse");
foreach(var a in ar)
{
    Console.WriteLine(a);
}
Console.WriteLine("number of elements" + ar.Count);
//The capacity of an ArrayList is the number of elements the ArrayList can hold.

Console.WriteLine("capacity" + ar.Capacity);

//HashTable
Hashtable ht = new Hashtable();
ht.Add("A1", "Welcome");
ht.Add("A2", "to");
ht.Add("A3", "GITHUB");
Console.WriteLine("hashtable_1");
foreach(DictionaryEntry ele in ht)
{
    // Console.WriteLine((string?)el.Key, el.Value);
    Console.WriteLine("{0} and {1} ", ele.Key, ele.Value);
}


Hashtable my_hashtable2 = new Hashtable() {
                                      {1, "hello"},
                                          {2, 234},
                                        {3, 230.45},
                                         {4, null}};

Console.WriteLine("Key and Value pairs from my_hashtable2:");

foreach (var ele2 in my_hashtable2.Keys)
{
    Console.WriteLine("{0}and {1}", ele2,my_hashtable2[ele2]);
}


