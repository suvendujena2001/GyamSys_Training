using System;

namespace MyApp
{
    public class ArrayDemo
    {
        public int[] arr1 = new int[3];
        public int[] arr2;

        public ArrayDemo(int[] arr)
        {
            arr1[0] = arr[0];
            arr1[1] = arr[1];
            arr1[2] = arr[2];
            arr2 = new int[] { 2, 3, 4, 5 };
        }

        public void arrayDisplay()
        {
            int[] arr3 = { 2, 4, 6, 7 };
            foreach (int a in arr3)
            {
                Console.Write(a + ",");
            }
        }
    }


}