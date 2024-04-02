using System;
using System.Collections;
using System.Collections.Generic;


    /*
    Length is a property that specifies the total number of elements in an array.
    Whereas, GetLength() is a pre-defined method of the Array class. 
    It has an argument that specifies the dimension. If we pass 0 to GetLenth() method then it returns the size of the first dimension.
    And if we pass 1 to GetLegnth() method then it returns the size of the second dimension.
    */
    //Multidimension Array

    //int[,] mularr = new int[3, 2];

    //mularr[0, 0] = 4;//default value is 0.
    //mularr[0, 1] = 9;//showing error?
    //Console.WriteLine(mularr[1][1]);WRONG

    int[,] arra = new int[3, 2]
{
    {1,2 },
    {3,4 },
    {5,6 }
};

Console.WriteLine(arra[1,1]);

//Jagged Array- all the elements of jagged array are also array
int[][] num;
//no of rows is initialized
//num = new int[][]{...}; ./net will cal the num of rows automatically and willl assigin the no of rows.
num = new int[3][]
{   //0
    new int[]{1,2,3,4,5 } ,

    //new int[3]{2,3,4},

    //1
    new int[]{11,23 },

    //2
    new int[]{ 848,88,88,88,88,88,98 }

};


//num[0] = new int[5] {5,8,48,34,89};
//num[1] = new int[2];
//num[2] = new int[3];

//simple way to do
//int [][] dem = {
//  new int[]{1,2,3,4},
//    new int[] { 5,6,4},
//    new int[] {8}
//  };


//Read the value form jagged array
Console.WriteLine(num[1][1]);
for (int i = 0; i < num.Length; i++)
{
    for (int j = 0; j < num[i].Length; j++)
    {
        Console.Write(num[i][j] + "\t");
    }
    Console.WriteLine();
}

//What id we have multidimension array as the elements of jagged array?
int[][,] numb = new int[3][,];
numb[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
numb[1] = new int[2, 4] { { 1, 2, 3, 4 }, { 3, 4, 5, 6 } };
numb[2] = new int[4, 2] { { 6, 7 }, { 7, 8 }, { 6, 7 }, { 89, 76 } };
Console.WriteLine("printing multidiemension Jagged array");
for (int i = 0; i < numb.Length; i++)
{
    //int len = numb[i]; is wrong because in this we are ref. the array not the single element or integer
    var len = numb[i];
    //Console.WriteLine("printing multidiemension Jagged array");
    for (int j = 0; j < len.GetLength(0); j++)
    {
        //Console.WriteLine("printing multidiemension Jagged array");
        for (int k = 0; k < len.GetLength(1); k++)
        {
            
            Console.Write(len[j, k] + "\t");
        }
    }
    Console.WriteLine();
}

ArrayList ar = new ArrayList();
ar.Add(1);
ar.Add(2);
ar.Add(null);
ar.Add('1');
ar.Add("12");
ar.Add("cse");
foreach (var a in ar)
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
foreach (DictionaryEntry ele in ht)
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
    Console.WriteLine("{0}and {1}", ele2, my_hashtable2[ele2]);
}
Console.ReadKey();
/*
BitArray ba = new BitArray(8);
BitArray ba1 = new BitArray(8);//how many bits it can store - 8 bits can be stored 

//storing the value

byte[] a = { 65 };
byte[] b = { 12 };

ba = new BitArray(a);
ba1 = new BitArray(b);
Console.WriteLine(" bit array");
foreach(bool c in ba)
{
    Console.Write(c + "");
}
Console.ReadKey();
*/
BitArray ba = new BitArray(new byte[] { 65 });
BitArray ba1 = new BitArray(new byte[] { 12 });

Console.WriteLine("bit array 1: ");
foreach (bool c in ba)
{
    Console.Write(c + "");
}

Console.WriteLine("\nbit array 2: ");
foreach (bool c in ba1)
{
    Console.Write(c + "");
}

Console.ReadKey();
BitArray res = new BitArray(8);
res = ba.And(ba1);
Console.WriteLine("anding");
foreach (bool c in res)
{
    Console.Write(c + "");
}
Console.ReadKey();
Console.WriteLine("checking the original bitarray");
foreach (bool c in ba)
{
    Console.Write(c + "");
}
Console.ReadKey();