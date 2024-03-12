//Single dimensional array

// Declaration with initialization
int[] numbers = new int[] { 1, 2, 3, 4, 5 };

// Accessing elements
Console.WriteLine("First element: " + numbers[0]);  // Output: 1
Console.WriteLine("Second element: " + numbers[1]); // Output: 2

// Modifying elements
numbers[2] = 10;

// Iterating over array
foreach (int num in numbers)
{
    Console.WriteLine(num);
}

//Multi dimensional array

// Declaration with initialization
int[,] matrix = new int[3, 3] {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

// Accessing elements
Console.WriteLine("Element at [1,1]: " + matrix[1, 1]); // Output: 5

//Jagged array - aslo called array of arrays.when we want to take multiple arrays of different sizes.

// Declaration with initialization
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] {1, 2};
jaggedArray[1] = new int[] {3, 4, 5};
jaggedArray[2] = new int[] {6, 7, 8, 9};

// Accessing elements
Console.WriteLine("Element at [1][1]: " + jaggedArray[1][1]); // Output: 4

//Param arrays:A param array allows a method to accept a variable number of arguments.

// Method with param array
static void DisplayNumbers(params int[] numbers)
{
    Console.WriteLine("Total numbers: " + numbers.Length);
    foreach (int num in numbers)
    {
        Console.WriteLine(num);
    }
}

// Calling a method with a param array
DisplayNumbers(1, 2, 3, 4, 5);
