﻿using System;

class Program
{
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


      /* Console.WriteLine(marks3);
        Console.WriteLine ($"your roll no:{ roll}"); // String interpolation.
        Console.WriteLine(roll1);
        Console.WriteLine(roll2);
        Console.Read();*/


        /*  
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
        Console.Read(); */

        // ARRAYS-
        string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

        Console.WriteLine($"First: {fraudulentOrderIDs[0]},Second: {fraudulentOrderIDs[1]},Third: {fraudulentOrderIDs[2]}");
        fraudulentOrderIDs[0] = "F000";//reassigning 1st element.
        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"First: {fraudulentOrderIDs[0]},Second: {fraudulentOrderIDs[1]},Third: {fraudulentOrderIDs[2]}");*/
        Console.Read();
    }
}
