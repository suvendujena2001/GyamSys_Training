using System.Collections;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

namespace dotnet;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Abhishek");


        //if-else
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }

        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }

        if (total >= 15)
        {
            Console.WriteLine("You win!");
        }

        if (total < 15)
        {
            Console.WriteLine("Sorry, you lose.");
        }
        //array

        


        string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


        //for each
        int[] inventory = { 200, 450, 700, 175, 250 };
        int sum = 0;
        int bin = 0;
        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} items in inventory.");


        //multidimensinoal array
        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.WriteLine(numbers[i, j]);
            }
        }


        //stack

        Stack myStack = new Stack();
        myStack.Push("Hello Ahishek!");
        myStack.Push(1);
        myStack.Push(2);

        foreach (var item in myStack)
            Console.WriteLine(item);


        // queue
        Queue queue = new Queue();
        queue.Enqueue(3);
        queue.Enqueue("Two");
        queue.Enqueue(1);

        Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

        while (queue.Count > 0)
            Console.WriteLine(queue.Dequeue());

        Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);


        //CONDITIONAL OPERATOR
        int saleAmount = 1001;
        Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


        /* Random flip = new Random();
         int flip= flip.Next(0,2);
         Console.WriteLine($"Result: {((flip == 0 )? tails : heads)}");*/

        //
        string name = "steve";

        if (name == "bob")
            Console.WriteLine("Found Bob");
        else if (name == "steve")
            Console.WriteLine("Found Steve");
        else
            Console.WriteLine("Found Chuck");


        //switch case
        int employeeLevel = 200;
        string employeeName = "John Smith";

        string title = "";

        switch (employeeLevel)
        {
            case 100:
                title = "Junior Associate";
                break;
            case 200:
                title = "Senior Associate";
                break;
            case 300:
                title = "Manager";
                break;
            case 400:
                title = "Senior Manager";
                break;
            default:
                title = "Associate";
                break;
        }

        Console.WriteLine($"{employeeName}, {title}");

        
           string sku = "01-MN-L";
            string[] product = sku.Split('-');
            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = " sweat shirt";
                    break;
                case "02":
                    type = "t-shirt";
                    break;
                case "03":
                    type = "sweat-pants";
                    break;
                default:
                    type = "other";
                    break;
            }
            switch (product[1])
            {
                case "BL":
                    color = "black";
                    break;
                case "MN":
                    color = "maroon";
                    break;
                default:
                    color = "white";
                    break;
            }
            switch (product[2])
            {
                case "S":
                    size = "small";
                    break;
                case "M":
                    size = "medium";
                    break;
                case "L":
                    size = "large";
                    break;
                default:
                    size = "one size fits all";
                break;
            }

            Console.WriteLine($"Product:{size} {color} {type}");
        

        //for loop
       for(int i = 0; i <= 100; i++)
        {
            if(i%3 == 0)
            {
                Console.WriteLine(i + "-fizz");
            }
            else if (i%5 == 0) {
                Console.WriteLine(i + "-buzz");            
            }
            else  {
                Console.WriteLine( i + " -fizzbuzz");
            }
            Console.WriteLine(" ");
           
        }

        //type casting

        decimal myDecimal = 3.14m;
        Console.WriteLine($"decimal: {myDecimal}");

        int myInt = (int)myDecimal;
        Console.WriteLine($"int: {myInt}");

        string first = "5";
        string second = "7";
        int sum1 = int.Parse(first) + int.Parse(second);
        Console.WriteLine(sum1);



        string value = "102";
        int result = 0;
        if (int.TryParse(value, out result))
        {
            Console.WriteLine($"Measurement: {result}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }
        Console.WriteLine($"Measurement (w/ offset): {50 + result}");

    }
}
