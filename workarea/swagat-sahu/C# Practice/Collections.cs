using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Collections1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ArrL = new ArrayList();//ArrayList
            ArrL.Add(1);
            ArrL.Add(2);
            ArrL.Add(3);
            ArrL.Add(4);
            ArrL.Add(5);
            ArrL.Add(6);
            Console.WriteLine(ArrL);
            for (int i = 0; i < ArrL.Count; i++)
            {
                Console.WriteLine(ArrL[i]);

            }
            Hashtable ht1 = new Hashtable();//HashTable

            
            ht1.Add("1", "One");
            ht1.Add("4", "Four");
            ht1.Add("3", "Three");
            ht1.Add("2", "Two");
            
            
            foreach(DictionaryEntry i in ht1)
            {
                Console.WriteLine(i.Key + " and " + i.Value);
            }
            SortedList sl1 = new SortedList();//SortedList

            
            sl1.Add(1, "One");
            sl1.Add(4, "Four");
            sl1.Add(3, "Three");
            sl1.Add(2, "Two");
            foreach(DictionaryEntry i in  sl1) 
            {
                Console.WriteLine(i.Key + " and " + i.Value);
            }
            Stack st1 = new Stack();//Stack

            
            st1.Push("1");
            st1.Push("2");
            st1.Push("3");
            st1.Push("4");
            st1.Push("5");
            st1.Push("6");

             
            Console.Write("Total number of elements in the Stack are : ");

            Console.WriteLine(st1.Count);
            Queue qu1 = new Queue();//Queue
            qu1.Enqueue("1");
            qu1.Enqueue("2");
            qu1.Enqueue("3");
            qu1.Enqueue("4");
            qu1.Enqueue("5");
            qu1.Enqueue("6");
            
            Console.WriteLine(qu1.Count);

            Console.ReadLine();
          
        }
    }
}
