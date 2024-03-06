using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList - An ArrayList is a dynamic collection that can hold elements of any data type.
            ArrayList arrList = new ArrayList();
            arrList.Add(1234);
            arrList.Add("OneTwoThreeFour");
            foreach(var i in arrList)
            {
                Console.WriteLine(i);
            }


            //Hashtable- A Hashtable stores key-value pairs, where each key is unique.
            Hashtable ht = new Hashtable();
            ht.Add("Name", "Ayush"); 
            ht.Add("Age", 22);
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"{entry.Key}:{entry.Value}");
            }


            //SortedList- A SortedList maintains a sorted order based on keys.
            SortedList sortedList = new SortedList();
            sortedList.Add("Apple", 10);
            sortedList.Add("Grapes", 20);
            sortedList.Add("Banana", 5);

            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine($"{entry.Key}:{entry.Value}");

            }

            //Stack- Acts as a container for storing elements. Elements are added and removed from the top(LIFO).

            Stack stack = new Stack();
            stack.Push("1"); 
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");
            stack.Push("5");
            stack.Pop();

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
    

            //Queue- A Queue follows the First-In-First-Out (FIFO) principle.
            Queue queue = new Queue();

            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            queue.Enqueue("4");

            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }


            //BitArray- A BitArray represents an array of Boolean values (bits).
            BitArray bitArray = new BitArray(5);
            bitArray[0] = true;
            bitArray[1] = true;
            bitArray[2] = false;
            bitArray[3] = false;
            bitArray[4] = false;
            PrintValues(bitArray);
        }
        public static void PrintValues(IEnumerable myArr)
        {
            foreach (object obj in myArr)
            {
                Console.Write($"{obj,5}"); 
            }
            Console.WriteLine(); 
        }
    }
}
