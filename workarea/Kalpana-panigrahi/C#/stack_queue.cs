using System;
using System.Collections;
 
public class Program
{
    public static void Main()
    {
        // SortedList example
        SortedList sortedList = new SortedList();
        sortedList.Add("three", 3);
        sortedList.Add("one", 1);
        sortedList.Add("two", 2);
 
        // Displaying the sorted list
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
        }
 
        // Stack example
        Stack stack = new Stack();
        stack.Push("One");
        stack.Push("Two");
        stack.Push("Three");
 
        // Popping elements from the stack
        while (stack.Count > 0)
        {
            Console.WriteLine("Popped element: {0}", stack.Pop());
        }
 
        // Queue example
        Queue queue = new Queue();
        queue.Enqueue("One");
        queue.Enqueue("Two");
        queue.Enqueue("Three");
 
        // Dequeuing elements from the queue
        while (queue.Count > 0)
        {
            Console.WriteLine("Dequeued element: {0}", queue.Dequeue());
        }
 
        // BitArray example
        BitArray bitArray = new BitArray(4);
        bitArray.Set(0, true);
        bitArray.Set(1, false);
        bitArray.Set(2, true);
        bitArray.Set(3, false);
 
        // Displaying the bit array
        foreach (bool bit in bitArray)
        {
            Console.WriteLine(bit);
        }
 
        Console.ReadLine();
    }
}