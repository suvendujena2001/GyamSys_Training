using System.Collections;
using System.Numerics;

namespace dotnet_practice;

class Program
{
    public void result(params object[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {

                Console.WriteLine(array[i]);
        }
    }
    static int add(int a,int b) 
    {
            return a + b;
    }
    static int add(int a, int b,int c)
    {
        return a + b + c;
    }
    static void printArray(ArrayList arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item,item);
        }

    }
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello, Avinash");
        DateTime a = DateTime.Now;
        double y = 10.7;
        int y=int.TryParse(x,out y);
        Console.WriteLine(y);
        bool z = Convert.ToBoolean(y);
        Console.WriteLine(z);
        string str = "Avinash";
        Console.WriteLine($"Hey {str} ");

        bool? a = true;
        Console.WriteLine(a ?? false);

        Console.WriteLine((a.HasValue) ? "yes":"no");

        //array

        int[] arr = { 1, 2, 3, 4 };
        foreach (var item in arr)
        {   
        if(item==3)
            Console.WriteLine(item);
     
            
        }
        


        ArrayList arrayList = new ArrayList();
        arrayList.Add('a');
        arrayList.Add('b');
        arrayList.Add(2);

        printArray(arrayList);


        int[,] array2DInitialization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        Console.WriteLine(array2DInitialization.Length);
        Console.WriteLine(array2DInitialization.GetLength(0));


        int[][] jagged_arr = new int[4][];
        jagged_arr[0] = new int[] { 1, 2, 3, 4 };
        jagged_arr[1] = new int[] { 5, 6, 7 };
        jagged_arr[2] = new int[] { 1, 2, 3, 4 };
        jagged_arr[3] = new int[] { 5, 6, 7 };

        for (int i = 0; i < jagged_arr.Length; i++)
        {
            for(int j = 0; j < jagged_arr[i].Length; j++)
            {
                Console.Write(jagged_arr[i][j] + " ");
            }
            Console.WriteLine();
        }

       
        Program p1 = new Program();

        p1.result("Avinash", "Aditya",
                        100, "100");*/

        Hashtable hst = new Hashtable();


        hst.Add(1, "Avinash");
        hst.Add(2, "Harsh");
        hst.Add(3, "Rohit");
        hst.Add(4, "Avi");

        Console.WriteLine(hst);

        foreach (DictionaryEntry item in hst) 
        {
            Console.WriteLine("{0},{1}",item.Key, item.Value);
        }
        //method overloading

        //Console.WriteLine(add(1, 2));
        //Console.WriteLine(add(1, 2,6));

        try
        {
            string a = "hello";
            int b = Convert.ToInt32(a);
            
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("hello we are in final block");
        }

    }
    
}
