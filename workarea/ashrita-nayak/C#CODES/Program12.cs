using System;
using System.Collections;
class Merry
{
    static public void Main()
    {
        SortedList my_slist1 = new SortedList();
        my_slist1.Add(8.77, "Ishita");
        my_slist1.Add(24.33, "licked");
        my_slist1.Add(64.00, "the");
        my_slist1.Add(12.88, "ice-cream");
foreach (DictionaryEntry pair in my_slist1)
        {
            Console.WriteLine("{0} and {1}",
                    pair.Key, pair.Value);
        }
        Console.WriteLine();


        SortedList my_slist2 = new SortedList() {
                                { "Mother", 234 },
                                { "sweeped", 395 },
                                { "the", 405 },
                                { "floor", 100 }};
 foreach (DictionaryEntry pair in my_slist2)
        {
            Console.WriteLine("{0} and {1}",
                    pair.Key, pair.Value);
        }
    }
}

