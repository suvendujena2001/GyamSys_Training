using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_in_C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             ArrayList : ordered collections of objects
            It is dynamic memory allocation .
             */

            ArrayList myList = new ArrayList();
            myList.Add(1);
            myList.Add("Hello");
            myList.Add(2);
            myList.Add(2);
            myList.Add(2);

            Console.WriteLine("Count is :" + myList.Count);
            Console.WriteLine("Capacity is : " + myList.Capacity);

            // to check if the arraylist has fixed size or not
            Console.WriteLine(myList.IsFixedSize);


            // to remove some elemnts.
            myList.RemoveRange(0, 2);
            Console.WriteLine("After removing the elements from arraylist");

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            /*
             HashTable : is a collection of key-value pair organised based on hash code of the key.
            In Hash Table , a key cannot be null but a value can be null.
             
             */


            Hashtable hash = new Hashtable();
            hash.Add(1, "Welcome");
            hash.Add(2, "To");
            hash.Add(3, "Learning");
            hash.Add(4, "of");
            hash.Add(5, "C#");

            ICollection key = hash.Keys;

            // print the hashtable
            Console.WriteLine("Hashtable :");
            Console.WriteLine();

            foreach(var val in key)
            {
                Console.WriteLine(val + "-" + hash[val]);
            }

            Console.WriteLine();

            // To remove element use remove() method

            hash.Remove("2");

            Console.WriteLine("After removing element :");

            foreach(var val in key)
            {
                Console.WriteLine(val + "-" + hash[val]);
            }


            /*  Stack : represent last in , first -out collection of objects
             stack is dynamic in nature */

            Stack my_stack = new Stack();
            //adding the elements

            my_stack.Push("Hello");
            my_stack.Push("World");
            my_stack.Push(1);
            my_stack.Push(2);
            my_stack.Push(30.9);

            //accessing the elements

            foreach(var elem in my_stack)
            {
                Console.WriteLine(elem);
            }

            // to remove elements from the stack 
            my_stack.Pop();
            Console.WriteLine("After removing the top element");
            foreach (var elem in my_stack)
            {
                Console.WriteLine(elem);
            }

            my_stack.Push(30.9);
            // topmost element of stack..
            Console.WriteLine("The topmost element of stack is:" + my_stack.Peek());

            // check element is present in stack or not

            if(my_stack.Contains("Hello") == true)
            {
                Console.WriteLine("Element is found!!!");
            }
            else
            {
                Console.WriteLine("Not Found!!");
            }


            /*Queue :
              Represent FIFO collection of objects.
                Adding a element is called :- Enqueue
                Remove a element is called :- Dequeue
              
             */
            
            Queue my_queue = new Queue();

            my_queue.Enqueue("Hello");
            my_queue.Enqueue("I am");
            my_queue.Enqueue("Suvam");
            my_queue.Enqueue(007);
            my_queue.Enqueue(0.9);

            //accessing each element
            foreach(var elem in my_queue)
            {
                Console.Write(" " + elem);
            }
            Console.WriteLine();

            //removing elements from queue
            //Clear : remove all
            // Dequeue : remove the begining element from the queue

            my_queue.Dequeue();
            Console.WriteLine("The total elements after removing the top");

            foreach (var elem in my_queue)
            {
                Console.WriteLine(elem);
            }


            /* 
             SortedList :
            Is a collection of key/value pairs which are sorted according to keys
            By default it is in ascending order.
             
             */
            SortedList my_list1 = new SortedList();
            my_list1.Add(1, "This");
            my_list1.Add(2, "Is");
            my_list1.Add(3, "SortedList");
            my_list1.Add(4, "In Collections");
            
            foreach(DictionaryEntry pair in my_list1)
            {
                Console.WriteLine("{0} and {1} " , pair.Key ,pair.Value);

            }
            Console.WriteLine();

            // remove elements from the sortedlist

            my_list1.Remove(2);

            Console.WriteLine("After removing elements from sortedlist :");
            foreach (DictionaryEntry pair in my_list1)
            {
                Console.WriteLine("{0} and {1} ", pair.Key, pair.Value);

            }
            Console.WriteLine();

            Console.WriteLine();

            // contains is used to check whether the element is contained in the sorted list or not.

            if (my_list1.Contains(2) == true)
            {
                Console.WriteLine("Key is found");
            }
            else
            {
                Console.WriteLine("Not found key..");

            }
            Console.WriteLine() ;
            Console.WriteLine();


            /* Bit Array :
             manages a compact array of bit values, represented by Booleans

             */

            BitArray myBit = new BitArray(5);
            myBit[0] = true;
            myBit[1]=false;
            myBit[2]=true;
            myBit[3]=false;
            myBit[4]=false;

            Console.WriteLine(myBit.Get(2));

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("New BitArray implementation :");

            BitArray bArr = new BitArray(5);
            bArr[0] = true;
            bArr[1] = false;
            bArr[2] = true;
            bArr[3]=true; bArr[4]=false;
            BitArray bArr2 = new BitArray(5);
            bArr2[0] = true;
            bArr2[1] = true;
            bArr2[2] = false;
            bArr2[3] = true;
            bArr2[4] = false;

            Console.WriteLine("BitArray 1 :");
            for(int i = 0;i<bArr.Length;i++)
            {
                Console.Write(bArr[i]);
                Console.Write(" ");

            }
            Console.WriteLine();
            Console.WriteLine("BitArray 2:");
            for(int i = 0; i < bArr2.Length; i++)
            {
                Console.Write(bArr2[i]);
                Console.Write(" ");
            }

            bArr.And(bArr2);
            Console.WriteLine();
            Console.WriteLine("BitArray after AND operation:");
            for(int i = 0; i < bArr.Length; i++)
            {
                Console.Write(bArr[i]);
                Console.Write(" ");

            }
            Console.WriteLine() ;
            Console.WriteLine(bArr.IsReadOnly);

            bool s = bArr[3];
            Console.WriteLine("4th element = " + s);


        
        }

    }
}
