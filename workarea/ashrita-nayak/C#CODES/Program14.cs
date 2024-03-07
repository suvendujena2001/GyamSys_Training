using System;
using System.Collections.Generic;
class Rooftop
{
    static void Main()
    {
        Queue<int> myQueue = new Queue<int>();
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);
        while (myQueue.Count > 0)
        {
            int element = myQueue.Dequeue();
            Console.WriteLine($"Dequeued: {element}");
        }
        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        while (myStack.Count > 0)
        {
            int element = myStack.Pop();
            Console.WriteLine($"Popped: {element}");
        }
    }
}




