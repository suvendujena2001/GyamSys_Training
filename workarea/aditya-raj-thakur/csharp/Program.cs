using System;
using System.Collections;


class Program
{    // Method
    static int Method(int x, int y)
    {
        return x + y;
    }
    static void PrintValues(IEnumerable myList)
    {
        foreach (Object obj in myList)
        {
            Console.WriteLine(obj);
        }
    }
    public static void Main(String[] args)
    {
        /* Random dice=new Random (); //instance of random class
        int roll=dice.Next(1, 7);
        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(8, 50);
        int marks1 = 200;
        int marks = 300;
        int marks3 = Math.Max(marks1, marks);//math.max
        Console.WriteLine(marks3);


        Console.WriteLine(marks3);
        Console.WriteLine ($"your roll no:{ roll}"); // String interpolation.
        Console.WriteLine(roll1);
        Console.WriteLine(roll2);
        Console.Read();


          
         IF -ELSE IF BLOCK

        Random random = new Random();
        int Expiration = random.Next(10);
        int discountPercentage = 0;
        if (Expiration <= 10 && Expiration>5)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
        else if (Expiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in {Expiration} days.\r\n" +
                "Renew now and save 10%!");
        }
        else
        {
            Console.WriteLine("Your subscription has expired.");
        }
        Console.Read(); 

        ARRAYS-

        string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

        Console.WriteLine($"First: {fraudulentOrderIDs[0]},Second: {fraudulentOrderIDs[1]},Third: {fraudulentOrderIDs[2]}");
        fraudulentOrderIDs[0] = "F000";//reassigning 1st element.
        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"First: {fraudulentOrderIDs[0]},Second: {fraudulentOrderIDs[1]},Third: {fraudulentOrderIDs[2]}");
        
        FOR -EACH LOOP


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

        string originalMessage = "The quick brown fox jumps over the lazy dog.";

        char[] message = originalMessage.ToCharArray();
        Array.Reverse(message);

        int letterCount = 0;

        foreach (char letter in message)
        {
            if (letter == 'o')
            {
                letterCount++;
            }
        }

        string newMessage = new String(message);

        Console.WriteLine(newMessage);
        Console.WriteLine($"'o' appears {letterCount} times");


        int saleAmount = 1001;
        int Amount = 50;
        int discount = saleAmount > 1000 ? 100 : 50;// true
        int discount1 = Amount > 100 ? 50 : 10;// false
        Console.WriteLine($"Discount: {discount}");
        Console.WriteLine($"Discount: {discount1}");

        SWITCH 

        int employeeLevel = 100;
        string employeeName = "John";

        string title = "";

        switch (employeeLevel)
        {
            case 100:
            case 200:
            case 300:
                title = "Manager";//assign the next given title 
                break;
            case 400:
                title = "Senior Manager";
                break;
            default:
                title = "Associate";
                break;
        }

        Console.WriteLine($"{employeeName}, {title}");

       // DO_WHILE

        Random random = new Random();
        int current = random.Next(1, 11);

        do
        {
            current = random.Next(1, 11);

            if (current >= 8) continue;

            Console.WriteLine(current);
        } while (current != 7);

       
        // 2D _ARRAY

        // using Foreach
       int[,] Arr = { { 1, 2, 3 },{ 4, 5, 6 } };
        foreach(int i in Arr)
        {
            Console.WriteLine(i);
        }

        //Using For loop.
        for(int i = 0; i < Arr.GetLength(0); i++)
        {
            for(int j = 0; j < Arr.GetLength(1); j++)
            {
                Console.WriteLine(Arr[i,j]);
            }
        }

        Console.WriteLine(Arr[1, 1]);

        //JAGGED ARRAY- array of arrays
        int[][] jagged_arr = new int[4][];
        
        jagged_arr[0]= new int[]{1,2,3,4};
        jagged_arr[1] = new int[] { 5, 6 };
        jagged_arr[2] = new int[] { 7, 8, 9 };

        for (int n = 0; n < jagged_arr.Length; n++)
        {

            // Print the row number
            Console.WriteLine("Row({0}): ", n);

            for (int k = 0; k < jagged_arr[n].Length; k++)
            {

                // Print the elements in the row
                Console.WriteLine("{0} ", jagged_arr[n][k]);

            }
            System.Console.WriteLine();

        }
        //PARAM ARRAYS-
        

        object[] obj = new object[6];
        obj[0] = 1;
        obj[1] = "Two";
        obj[2] = 3;
        obj[3] = "Four";
        obj[4] = 5;
        obj[5] = false;

        PrintValues(obj);
         static void PrintValues(params object[] obj)
        {
            foreach (object o in obj)
                Console.WriteLine(o);
        } 

        // Method
            int z = Method(6, 3);
            Console.WriteLine(z);
        
        // ArrayList
           ArrayList myList = new ArrayList();

            myList.Add("A");
            myList.Add("B");
            myList.Add("C");
            myList.Add("D");
            myList.Add("E");
            myList.Add("F");
            myList.Add("G");
            myList.Add("H");
            myList.Add("I");
            if (myList.Contains("H"))
                Console.WriteLine("Yes, exists at index " + myList.IndexOf("H"));
            else
                Console.WriteLine("No, doesn't exists");
        
        // Hashtable

           Hashtable my_hashtable1 = new Hashtable();

            
            my_hashtable1.Add("A1", "Welcome");
            my_hashtable1.Add("A2", "to");
            my_hashtable1.Add("A3", "Programming");

            Console.WriteLine("Key and Value pairs from my_hashtable1:");

            foreach (DictionaryEntry ele1 in my_hashtable1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }
        // Stack
            Stack my_stack = new Stack();

            
            my_stack.Push("ADI");
            my_stack.Push("HELLLOOO");
            my_stack.Push("HELL23");
            my_stack.Push("HEMLOOOO");

           
            if (my_stack.Contains("GeeksforGeeks") == true)
            {
                Console.WriteLine("Element is found...!!");
            }

            else
            {
                Console.WriteLine("Element is not found...!!");
            }
        // QUEUE
       
            Queue my_queue = new Queue();

            
            my_queue.Enqueue("ADI");
            my_queue.Enqueue(1);
            my_queue.Enqueue(100);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("Hello123");

            
            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }
        
       
        
            //Bit array-
            BitArray myBitArr1 = new BitArray(4);
            myBitArr1[0] = false;
            myBitArr1[1] = false;
            myBitArr1[2] = true;
            myBitArr1[3] = true;
          PrintValues(myBitArr1);
        }*/
         // Sorted List--key value pair, sort on key

        SortedList my_slist1 = new SortedList();
            my_slist1.Add(1.02, "This");
            my_slist1.Add(1.07, "Is");
            my_slist1.Add(1.04, "SortedList");


            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("{0} and {1}",
                        pair.Key, pair.Value);
            }
            Console.WriteLine();
        

        
         Console.Read();
       
        
    }
}
       
